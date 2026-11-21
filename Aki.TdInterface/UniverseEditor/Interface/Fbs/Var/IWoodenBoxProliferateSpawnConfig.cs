using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F37 RID: 16183
	public struct IWoodenBoxProliferateSpawnConfig : IFlatbufferObject
	{
		// Token: 0x17006DA0 RID: 28064
		// (get) Token: 0x0601601D RID: 90141 RVA: 0x003296C0 File Offset: 0x003278C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601601E RID: 90142 RVA: 0x003296CD File Offset: 0x003278CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601601F RID: 90143 RVA: 0x003296D4 File Offset: 0x003278D4
		public static IWoodenBoxProliferateSpawnConfig GetRootAsIWoodenBoxProliferateSpawnConfig(ByteBuffer _bb)
		{
			return IWoodenBoxProliferateSpawnConfig.GetRootAsIWoodenBoxProliferateSpawnConfig(_bb, default(IWoodenBoxProliferateSpawnConfig));
		}

		// Token: 0x06016020 RID: 90144 RVA: 0x003296F0 File Offset: 0x003278F0
		public static IWoodenBoxProliferateSpawnConfig GetRootAsIWoodenBoxProliferateSpawnConfig(ByteBuffer _bb, IWoodenBoxProliferateSpawnConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016021 RID: 90145 RVA: 0x0032970D File Offset: 0x0032790D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016022 RID: 90146 RVA: 0x0032971C File Offset: 0x0032791C
		public IWoodenBoxProliferateSpawnConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006DA1 RID: 28065
		// (get) Token: 0x06016023 RID: 90147 RVA: 0x0032972C File Offset: 0x0032792C
		public EWoodenBoxProliferateSpawnType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWoodenBoxProliferateSpawnType.RandomInRange;
				}
				return (EWoodenBoxProliferateSpawnType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016024 RID: 90148 RVA: 0x00329768 File Offset: 0x00327968
		public static Offset<IWoodenBoxProliferateSpawnConfig> CreateIWoodenBoxProliferateSpawnConfig(FlatBufferBuilder builder, EWoodenBoxProliferateSpawnType Type = EWoodenBoxProliferateSpawnType.RandomInRange)
		{
			builder.StartTable(1);
			IWoodenBoxProliferateSpawnConfig.AddType(builder, Type);
			return IWoodenBoxProliferateSpawnConfig.EndIWoodenBoxProliferateSpawnConfig(builder);
		}

		// Token: 0x06016025 RID: 90149 RVA: 0x0032977E File Offset: 0x0032797E
		public static void StartIWoodenBoxProliferateSpawnConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016026 RID: 90150 RVA: 0x00329787 File Offset: 0x00327987
		public static void AddType(FlatBufferBuilder builder, EWoodenBoxProliferateSpawnType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016027 RID: 90151 RVA: 0x00329792 File Offset: 0x00327992
		public static Offset<IWoodenBoxProliferateSpawnConfig> EndIWoodenBoxProliferateSpawnConfig(FlatBufferBuilder builder)
		{
			return new Offset<IWoodenBoxProliferateSpawnConfig>(builder.EndTable());
		}

		// Token: 0x06016028 RID: 90152 RVA: 0x003297A0 File Offset: 0x003279A0
		public IWoodenBoxProliferateSpawnConfigT UnPack()
		{
			IWoodenBoxProliferateSpawnConfigT woodenBoxProliferateSpawnConfigT = new IWoodenBoxProliferateSpawnConfigT();
			this.UnPackTo(woodenBoxProliferateSpawnConfigT);
			return woodenBoxProliferateSpawnConfigT;
		}

		// Token: 0x06016029 RID: 90153 RVA: 0x003297BB File Offset: 0x003279BB
		public void UnPackTo(IWoodenBoxProliferateSpawnConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601602A RID: 90154 RVA: 0x003297CC File Offset: 0x003279CC
		public static Offset<IWoodenBoxProliferateSpawnConfig> Pack(FlatBufferBuilder builder, IWoodenBoxProliferateSpawnConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWoodenBoxProliferateSpawnConfig>);
			}
			return IWoodenBoxProliferateSpawnConfig.CreateIWoodenBoxProliferateSpawnConfig(builder, _o.Type);
		}

		// Token: 0x0400B983 RID: 47491
		private Table __p;
	}
}
