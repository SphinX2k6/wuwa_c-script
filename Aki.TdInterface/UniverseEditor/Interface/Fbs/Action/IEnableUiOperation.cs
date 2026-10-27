using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200669C RID: 26268
	public struct IEnableUiOperation : IFlatbufferObject
	{
		// Token: 0x1700C336 RID: 49974
		// (get) Token: 0x0602DA7F RID: 187007 RVA: 0x0063F84E File Offset: 0x0063DA4E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DA80 RID: 187008 RVA: 0x0063F85B File Offset: 0x0063DA5B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DA81 RID: 187009 RVA: 0x0063F864 File Offset: 0x0063DA64
		public static IEnableUiOperation GetRootAsIEnableUiOperation(ByteBuffer _bb)
		{
			return IEnableUiOperation.GetRootAsIEnableUiOperation(_bb, default(IEnableUiOperation));
		}

		// Token: 0x0602DA82 RID: 187010 RVA: 0x0063F880 File Offset: 0x0063DA80
		public static IEnableUiOperation GetRootAsIEnableUiOperation(ByteBuffer _bb, IEnableUiOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DA83 RID: 187011 RVA: 0x0063F89D File Offset: 0x0063DA9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DA84 RID: 187012 RVA: 0x0063F8AC File Offset: 0x0063DAAC
		public IEnableUiOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C337 RID: 49975
		// (get) Token: 0x0602DA85 RID: 187013 RVA: 0x0063F8BC File Offset: 0x0063DABC
		public EUiOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EUiOperationType.Enable;
				}
				return (EUiOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DA86 RID: 187014 RVA: 0x0063F8F8 File Offset: 0x0063DAF8
		public static Offset<IEnableUiOperation> CreateIEnableUiOperation(FlatBufferBuilder builder, EUiOperationType Type = EUiOperationType.Enable)
		{
			builder.StartTable(1);
			IEnableUiOperation.AddType(builder, Type);
			return IEnableUiOperation.EndIEnableUiOperation(builder);
		}

		// Token: 0x0602DA87 RID: 187015 RVA: 0x0063F90E File Offset: 0x0063DB0E
		public static void StartIEnableUiOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DA88 RID: 187016 RVA: 0x0063F917 File Offset: 0x0063DB17
		public static void AddType(FlatBufferBuilder builder, EUiOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DA89 RID: 187017 RVA: 0x0063F922 File Offset: 0x0063DB22
		public static Offset<IEnableUiOperation> EndIEnableUiOperation(FlatBufferBuilder builder)
		{
			return new Offset<IEnableUiOperation>(builder.EndTable());
		}

		// Token: 0x0602DA8A RID: 187018 RVA: 0x0063F930 File Offset: 0x0063DB30
		public IEnableUiOperationT UnPack()
		{
			IEnableUiOperationT enableUiOperationT = new IEnableUiOperationT();
			this.UnPackTo(enableUiOperationT);
			return enableUiOperationT;
		}

		// Token: 0x0602DA8B RID: 187019 RVA: 0x0063F94B File Offset: 0x0063DB4B
		public void UnPackTo(IEnableUiOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DA8C RID: 187020 RVA: 0x0063F95C File Offset: 0x0063DB5C
		public static Offset<IEnableUiOperation> Pack(FlatBufferBuilder builder, IEnableUiOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableUiOperation>);
			}
			return IEnableUiOperation.CreateIEnableUiOperation(builder, _o.Type);
		}

		// Token: 0x04010D57 RID: 68951
		private Table __p;
	}
}
