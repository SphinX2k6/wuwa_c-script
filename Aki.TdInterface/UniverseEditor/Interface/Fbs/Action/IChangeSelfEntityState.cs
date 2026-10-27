using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006320 RID: 25376
	public struct IChangeSelfEntityState : IFlatbufferObject
	{
		// Token: 0x1700BD6D RID: 48493
		// (get) Token: 0x0602BE49 RID: 179785 RVA: 0x00608EB1 File Offset: 0x006070B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BE4A RID: 179786 RVA: 0x00608EBE File Offset: 0x006070BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BE4B RID: 179787 RVA: 0x00608EC8 File Offset: 0x006070C8
		public static IChangeSelfEntityState GetRootAsIChangeSelfEntityState(ByteBuffer _bb)
		{
			return IChangeSelfEntityState.GetRootAsIChangeSelfEntityState(_bb, default(IChangeSelfEntityState));
		}

		// Token: 0x0602BE4C RID: 179788 RVA: 0x00608EE4 File Offset: 0x006070E4
		public static IChangeSelfEntityState GetRootAsIChangeSelfEntityState(ByteBuffer _bb, IChangeSelfEntityState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BE4D RID: 179789 RVA: 0x00608F01 File Offset: 0x00607101
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BE4E RID: 179790 RVA: 0x00608F10 File Offset: 0x00607110
		public IChangeSelfEntityState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD6E RID: 48494
		// (get) Token: 0x0602BE4F RID: 179791 RVA: 0x00608F20 File Offset: 0x00607120
		public string EntityState
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BE50 RID: 179792 RVA: 0x00608F57 File Offset: 0x00607157
		public Span<byte> GetEntityStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602BE51 RID: 179793 RVA: 0x00608F66 File Offset: 0x00607166
		public byte[] GetEntityStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602BE52 RID: 179794 RVA: 0x00608F74 File Offset: 0x00607174
		public static Offset<IChangeSelfEntityState> CreateIChangeSelfEntityState(FlatBufferBuilder builder, StringOffset EntityStateOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IChangeSelfEntityState.AddEntityState(builder, EntityStateOffset);
			return IChangeSelfEntityState.EndIChangeSelfEntityState(builder);
		}

		// Token: 0x0602BE53 RID: 179795 RVA: 0x00608F8A File Offset: 0x0060718A
		public static void StartIChangeSelfEntityState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BE54 RID: 179796 RVA: 0x00608F93 File Offset: 0x00607193
		public static void AddEntityState(FlatBufferBuilder builder, StringOffset entityStateOffset)
		{
			builder.AddOffset(0, entityStateOffset.Value, 0);
		}

		// Token: 0x0602BE55 RID: 179797 RVA: 0x00608FA3 File Offset: 0x006071A3
		public static Offset<IChangeSelfEntityState> EndIChangeSelfEntityState(FlatBufferBuilder builder)
		{
			return new Offset<IChangeSelfEntityState>(builder.EndTable());
		}

		// Token: 0x0602BE56 RID: 179798 RVA: 0x00608FB0 File Offset: 0x006071B0
		public IChangeSelfEntityStateT UnPack()
		{
			IChangeSelfEntityStateT changeSelfEntityStateT = new IChangeSelfEntityStateT();
			this.UnPackTo(changeSelfEntityStateT);
			return changeSelfEntityStateT;
		}

		// Token: 0x0602BE57 RID: 179799 RVA: 0x00608FCB File Offset: 0x006071CB
		public void UnPackTo(IChangeSelfEntityStateT _o)
		{
			_o.EntityState = this.EntityState;
		}

		// Token: 0x0602BE58 RID: 179800 RVA: 0x00608FDC File Offset: 0x006071DC
		public static Offset<IChangeSelfEntityState> Pack(FlatBufferBuilder builder, IChangeSelfEntityStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeSelfEntityState>);
			}
			StringOffset entityStateOffset = (_o.EntityState == null) ? default(StringOffset) : builder.CreateString(_o.EntityState);
			return IChangeSelfEntityState.CreateIChangeSelfEntityState(builder, entityStateOffset);
		}

		// Token: 0x040108E3 RID: 67811
		private Table __p;
	}
}
