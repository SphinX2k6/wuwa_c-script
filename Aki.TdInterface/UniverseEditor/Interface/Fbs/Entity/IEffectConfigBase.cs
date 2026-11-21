using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BEC RID: 19436
	public struct IEffectConfigBase : IFlatbufferObject
	{
		// Token: 0x17008993 RID: 35219
		// (get) Token: 0x0601DAE6 RID: 121574 RVA: 0x0042A387 File Offset: 0x00428587
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DAE7 RID: 121575 RVA: 0x0042A394 File Offset: 0x00428594
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DAE8 RID: 121576 RVA: 0x0042A39C File Offset: 0x0042859C
		public static IEffectConfigBase GetRootAsIEffectConfigBase(ByteBuffer _bb)
		{
			return IEffectConfigBase.GetRootAsIEffectConfigBase(_bb, default(IEffectConfigBase));
		}

		// Token: 0x0601DAE9 RID: 121577 RVA: 0x0042A3B8 File Offset: 0x004285B8
		public static IEffectConfigBase GetRootAsIEffectConfigBase(ByteBuffer _bb, IEffectConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DAEA RID: 121578 RVA: 0x0042A3D5 File Offset: 0x004285D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DAEB RID: 121579 RVA: 0x0042A3E4 File Offset: 0x004285E4
		public IEffectConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008994 RID: 35220
		// (get) Token: 0x0601DAEC RID: 121580 RVA: 0x0042A3F4 File Offset: 0x004285F4
		public EEffectConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEffectConfigType.Death;
				}
				return (EEffectConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DAED RID: 121581 RVA: 0x0042A430 File Offset: 0x00428630
		public static Offset<IEffectConfigBase> CreateIEffectConfigBase(FlatBufferBuilder builder, EEffectConfigType Type = EEffectConfigType.Death)
		{
			builder.StartTable(1);
			IEffectConfigBase.AddType(builder, Type);
			return IEffectConfigBase.EndIEffectConfigBase(builder);
		}

		// Token: 0x0601DAEE RID: 121582 RVA: 0x0042A446 File Offset: 0x00428646
		public static void StartIEffectConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601DAEF RID: 121583 RVA: 0x0042A44F File Offset: 0x0042864F
		public static void AddType(FlatBufferBuilder builder, EEffectConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DAF0 RID: 121584 RVA: 0x0042A45A File Offset: 0x0042865A
		public static Offset<IEffectConfigBase> EndIEffectConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IEffectConfigBase>(builder.EndTable());
		}

		// Token: 0x0601DAF1 RID: 121585 RVA: 0x0042A468 File Offset: 0x00428668
		public IEffectConfigBaseT UnPack()
		{
			IEffectConfigBaseT effectConfigBaseT = new IEffectConfigBaseT();
			this.UnPackTo(effectConfigBaseT);
			return effectConfigBaseT;
		}

		// Token: 0x0601DAF2 RID: 121586 RVA: 0x0042A483 File Offset: 0x00428683
		public void UnPackTo(IEffectConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601DAF3 RID: 121587 RVA: 0x0042A494 File Offset: 0x00428694
		public static Offset<IEffectConfigBase> Pack(FlatBufferBuilder builder, IEffectConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEffectConfigBase>);
			}
			return IEffectConfigBase.CreateIEffectConfigBase(builder, _o.Type);
		}

		// Token: 0x0400D61C RID: 54812
		private Table __p;
	}
}
