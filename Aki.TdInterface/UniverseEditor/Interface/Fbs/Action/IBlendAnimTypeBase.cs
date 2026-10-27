using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200620C RID: 25100
	public struct IBlendAnimTypeBase : IFlatbufferObject
	{
		// Token: 0x1700BB15 RID: 47893
		// (get) Token: 0x0602B443 RID: 177219 RVA: 0x005F5CA6 File Offset: 0x005F3EA6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B444 RID: 177220 RVA: 0x005F5CB3 File Offset: 0x005F3EB3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B445 RID: 177221 RVA: 0x005F5CBC File Offset: 0x005F3EBC
		public static IBlendAnimTypeBase GetRootAsIBlendAnimTypeBase(ByteBuffer _bb)
		{
			return IBlendAnimTypeBase.GetRootAsIBlendAnimTypeBase(_bb, default(IBlendAnimTypeBase));
		}

		// Token: 0x0602B446 RID: 177222 RVA: 0x005F5CD8 File Offset: 0x005F3ED8
		public static IBlendAnimTypeBase GetRootAsIBlendAnimTypeBase(ByteBuffer _bb, IBlendAnimTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B447 RID: 177223 RVA: 0x005F5CF5 File Offset: 0x005F3EF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B448 RID: 177224 RVA: 0x005F5D04 File Offset: 0x005F3F04
		public IBlendAnimTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB16 RID: 47894
		// (get) Token: 0x0602B449 RID: 177225 RVA: 0x005F5D14 File Offset: 0x005F3F14
		public EBlendAnimType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBlendAnimType.StateMachine;
				}
				return (EBlendAnimType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B44A RID: 177226 RVA: 0x005F5D50 File Offset: 0x005F3F50
		public static Offset<IBlendAnimTypeBase> CreateIBlendAnimTypeBase(FlatBufferBuilder builder, EBlendAnimType Type = EBlendAnimType.StateMachine)
		{
			builder.StartTable(1);
			IBlendAnimTypeBase.AddType(builder, Type);
			return IBlendAnimTypeBase.EndIBlendAnimTypeBase(builder);
		}

		// Token: 0x0602B44B RID: 177227 RVA: 0x005F5D66 File Offset: 0x005F3F66
		public static void StartIBlendAnimTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B44C RID: 177228 RVA: 0x005F5D6F File Offset: 0x005F3F6F
		public static void AddType(FlatBufferBuilder builder, EBlendAnimType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B44D RID: 177229 RVA: 0x005F5D7A File Offset: 0x005F3F7A
		public static Offset<IBlendAnimTypeBase> EndIBlendAnimTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IBlendAnimTypeBase>(builder.EndTable());
		}

		// Token: 0x0602B44E RID: 177230 RVA: 0x005F5D88 File Offset: 0x005F3F88
		public IBlendAnimTypeBaseT UnPack()
		{
			IBlendAnimTypeBaseT blendAnimTypeBaseT = new IBlendAnimTypeBaseT();
			this.UnPackTo(blendAnimTypeBaseT);
			return blendAnimTypeBaseT;
		}

		// Token: 0x0602B44F RID: 177231 RVA: 0x005F5DA3 File Offset: 0x005F3FA3
		public void UnPackTo(IBlendAnimTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B450 RID: 177232 RVA: 0x005F5DB4 File Offset: 0x005F3FB4
		public static Offset<IBlendAnimTypeBase> Pack(FlatBufferBuilder builder, IBlendAnimTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlendAnimTypeBase>);
			}
			return IBlendAnimTypeBase.CreateIBlendAnimTypeBase(builder, _o.Type);
		}

		// Token: 0x04010748 RID: 67400
		private Table __p;
	}
}
