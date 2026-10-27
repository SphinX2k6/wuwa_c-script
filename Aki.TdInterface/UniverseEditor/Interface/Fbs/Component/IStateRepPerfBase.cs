using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059AD RID: 22957
	public struct IStateRepPerfBase : IFlatbufferObject
	{
		// Token: 0x1700AC4B RID: 44107
		// (get) Token: 0x06026E4A RID: 159306 RVA: 0x0055A107 File Offset: 0x00558307
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026E4B RID: 159307 RVA: 0x0055A114 File Offset: 0x00558314
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026E4C RID: 159308 RVA: 0x0055A11C File Offset: 0x0055831C
		public static IStateRepPerfBase GetRootAsIStateRepPerfBase(ByteBuffer _bb)
		{
			return IStateRepPerfBase.GetRootAsIStateRepPerfBase(_bb, default(IStateRepPerfBase));
		}

		// Token: 0x06026E4D RID: 159309 RVA: 0x0055A138 File Offset: 0x00558338
		public static IStateRepPerfBase GetRootAsIStateRepPerfBase(ByteBuffer _bb, IStateRepPerfBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026E4E RID: 159310 RVA: 0x0055A155 File Offset: 0x00558355
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026E4F RID: 159311 RVA: 0x0055A164 File Offset: 0x00558364
		public IStateRepPerfBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC4C RID: 44108
		// (get) Token: 0x06026E50 RID: 159312 RVA: 0x0055A174 File Offset: 0x00558374
		public EStateRepPerfType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EStateRepPerfType.SkillId;
				}
				return (EStateRepPerfType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026E51 RID: 159313 RVA: 0x0055A1B0 File Offset: 0x005583B0
		public static Offset<IStateRepPerfBase> CreateIStateRepPerfBase(FlatBufferBuilder builder, EStateRepPerfType Type = EStateRepPerfType.SkillId)
		{
			builder.StartTable(1);
			IStateRepPerfBase.AddType(builder, Type);
			return IStateRepPerfBase.EndIStateRepPerfBase(builder);
		}

		// Token: 0x06026E52 RID: 159314 RVA: 0x0055A1C6 File Offset: 0x005583C6
		public static void StartIStateRepPerfBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026E53 RID: 159315 RVA: 0x0055A1CF File Offset: 0x005583CF
		public static void AddType(FlatBufferBuilder builder, EStateRepPerfType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026E54 RID: 159316 RVA: 0x0055A1DA File Offset: 0x005583DA
		public static Offset<IStateRepPerfBase> EndIStateRepPerfBase(FlatBufferBuilder builder)
		{
			return new Offset<IStateRepPerfBase>(builder.EndTable());
		}

		// Token: 0x06026E55 RID: 159317 RVA: 0x0055A1E8 File Offset: 0x005583E8
		public IStateRepPerfBaseT UnPack()
		{
			IStateRepPerfBaseT stateRepPerfBaseT = new IStateRepPerfBaseT();
			this.UnPackTo(stateRepPerfBaseT);
			return stateRepPerfBaseT;
		}

		// Token: 0x06026E56 RID: 159318 RVA: 0x0055A203 File Offset: 0x00558403
		public void UnPackTo(IStateRepPerfBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026E57 RID: 159319 RVA: 0x0055A214 File Offset: 0x00558414
		public static Offset<IStateRepPerfBase> Pack(FlatBufferBuilder builder, IStateRepPerfBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStateRepPerfBase>);
			}
			return IStateRepPerfBase.CreateIStateRepPerfBase(builder, _o.Type);
		}

		// Token: 0x0400EFBC RID: 61372
		private Table __p;
	}
}
