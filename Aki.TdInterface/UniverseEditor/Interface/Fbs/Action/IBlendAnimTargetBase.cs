using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006877 RID: 26743
	public struct IBlendAnimTargetBase : IFlatbufferObject
	{
		// Token: 0x1700C496 RID: 50326
		// (get) Token: 0x0602DB7E RID: 187262 RVA: 0x0064061D File Offset: 0x0063E81D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DB7F RID: 187263 RVA: 0x0064062A File Offset: 0x0063E82A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DB80 RID: 187264 RVA: 0x00640634 File Offset: 0x0063E834
		public static IBlendAnimTargetBase GetRootAsIBlendAnimTargetBase(ByteBuffer _bb)
		{
			return IBlendAnimTargetBase.GetRootAsIBlendAnimTargetBase(_bb, default(IBlendAnimTargetBase));
		}

		// Token: 0x0602DB81 RID: 187265 RVA: 0x00640650 File Offset: 0x0063E850
		public static IBlendAnimTargetBase GetRootAsIBlendAnimTargetBase(ByteBuffer _bb, IBlendAnimTargetBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DB82 RID: 187266 RVA: 0x0064066D File Offset: 0x0063E86D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DB83 RID: 187267 RVA: 0x0064067C File Offset: 0x0063E87C
		public IBlendAnimTargetBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C497 RID: 50327
		// (get) Token: 0x0602DB84 RID: 187268 RVA: 0x0064068C File Offset: 0x0063E88C
		public EBlendAnimTarget Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBlendAnimTarget.Player;
				}
				return (EBlendAnimTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DB85 RID: 187269 RVA: 0x006406C8 File Offset: 0x0063E8C8
		public static Offset<IBlendAnimTargetBase> CreateIBlendAnimTargetBase(FlatBufferBuilder builder, EBlendAnimTarget Type = EBlendAnimTarget.Player)
		{
			builder.StartTable(1);
			IBlendAnimTargetBase.AddType(builder, Type);
			return IBlendAnimTargetBase.EndIBlendAnimTargetBase(builder);
		}

		// Token: 0x0602DB86 RID: 187270 RVA: 0x006406DE File Offset: 0x0063E8DE
		public static void StartIBlendAnimTargetBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DB87 RID: 187271 RVA: 0x006406E7 File Offset: 0x0063E8E7
		public static void AddType(FlatBufferBuilder builder, EBlendAnimTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DB88 RID: 187272 RVA: 0x006406F2 File Offset: 0x0063E8F2
		public static Offset<IBlendAnimTargetBase> EndIBlendAnimTargetBase(FlatBufferBuilder builder)
		{
			return new Offset<IBlendAnimTargetBase>(builder.EndTable());
		}

		// Token: 0x0602DB89 RID: 187273 RVA: 0x00640700 File Offset: 0x0063E900
		public IBlendAnimTargetBaseT UnPack()
		{
			IBlendAnimTargetBaseT blendAnimTargetBaseT = new IBlendAnimTargetBaseT();
			this.UnPackTo(blendAnimTargetBaseT);
			return blendAnimTargetBaseT;
		}

		// Token: 0x0602DB8A RID: 187274 RVA: 0x0064071B File Offset: 0x0063E91B
		public void UnPackTo(IBlendAnimTargetBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DB8B RID: 187275 RVA: 0x0064072C File Offset: 0x0063E92C
		public static Offset<IBlendAnimTargetBase> Pack(FlatBufferBuilder builder, IBlendAnimTargetBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlendAnimTargetBase>);
			}
			return IBlendAnimTargetBase.CreateIBlendAnimTargetBase(builder, _o.Type);
		}

		// Token: 0x04011554 RID: 70996
		private Table __p;
	}
}
