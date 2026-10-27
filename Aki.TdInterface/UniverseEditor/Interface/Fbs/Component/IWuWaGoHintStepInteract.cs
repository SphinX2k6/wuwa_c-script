using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BB8 RID: 23480
	public struct IWuWaGoHintStepInteract : IFlatbufferObject
	{
		// Token: 0x1700B168 RID: 45416
		// (get) Token: 0x06028357 RID: 164695 RVA: 0x00586658 File Offset: 0x00584858
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028358 RID: 164696 RVA: 0x00586665 File Offset: 0x00584865
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028359 RID: 164697 RVA: 0x0058666C File Offset: 0x0058486C
		public static IWuWaGoHintStepInteract GetRootAsIWuWaGoHintStepInteract(ByteBuffer _bb)
		{
			return IWuWaGoHintStepInteract.GetRootAsIWuWaGoHintStepInteract(_bb, default(IWuWaGoHintStepInteract));
		}

		// Token: 0x0602835A RID: 164698 RVA: 0x00586688 File Offset: 0x00584888
		public static IWuWaGoHintStepInteract GetRootAsIWuWaGoHintStepInteract(ByteBuffer _bb, IWuWaGoHintStepInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602835B RID: 164699 RVA: 0x005866A5 File Offset: 0x005848A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602835C RID: 164700 RVA: 0x005866B4 File Offset: 0x005848B4
		public IWuWaGoHintStepInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B169 RID: 45417
		// (get) Token: 0x0602835D RID: 164701 RVA: 0x005866C4 File Offset: 0x005848C4
		public EWuWaGoHintStepType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWuWaGoHintStepType.Move;
				}
				return (EWuWaGoHintStepType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602835E RID: 164702 RVA: 0x00586700 File Offset: 0x00584900
		public static Offset<IWuWaGoHintStepInteract> CreateIWuWaGoHintStepInteract(FlatBufferBuilder builder, EWuWaGoHintStepType Type = EWuWaGoHintStepType.Move)
		{
			builder.StartTable(1);
			IWuWaGoHintStepInteract.AddType(builder, Type);
			return IWuWaGoHintStepInteract.EndIWuWaGoHintStepInteract(builder);
		}

		// Token: 0x0602835F RID: 164703 RVA: 0x00586716 File Offset: 0x00584916
		public static void StartIWuWaGoHintStepInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028360 RID: 164704 RVA: 0x0058671F File Offset: 0x0058491F
		public static void AddType(FlatBufferBuilder builder, EWuWaGoHintStepType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028361 RID: 164705 RVA: 0x0058672A File Offset: 0x0058492A
		public static Offset<IWuWaGoHintStepInteract> EndIWuWaGoHintStepInteract(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoHintStepInteract>(builder.EndTable());
		}

		// Token: 0x06028362 RID: 164706 RVA: 0x00586738 File Offset: 0x00584938
		public IWuWaGoHintStepInteractT UnPack()
		{
			IWuWaGoHintStepInteractT wuWaGoHintStepInteractT = new IWuWaGoHintStepInteractT();
			this.UnPackTo(wuWaGoHintStepInteractT);
			return wuWaGoHintStepInteractT;
		}

		// Token: 0x06028363 RID: 164707 RVA: 0x00586753 File Offset: 0x00584953
		public void UnPackTo(IWuWaGoHintStepInteractT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028364 RID: 164708 RVA: 0x00586764 File Offset: 0x00584964
		public static Offset<IWuWaGoHintStepInteract> Pack(FlatBufferBuilder builder, IWuWaGoHintStepInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoHintStepInteract>);
			}
			return IWuWaGoHintStepInteract.CreateIWuWaGoHintStepInteract(builder, _o.Type);
		}

		// Token: 0x0400F331 RID: 62257
		private Table __p;
	}
}
