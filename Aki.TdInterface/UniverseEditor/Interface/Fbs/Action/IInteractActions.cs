using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007031 RID: 28721
	public struct IInteractActions : IFlatbufferObject
	{
		// Token: 0x1700D24D RID: 53837
		// (get) Token: 0x06031C68 RID: 203880 RVA: 0x006BD059 File Offset: 0x006BB259
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031C69 RID: 203881 RVA: 0x006BD066 File Offset: 0x006BB266
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031C6A RID: 203882 RVA: 0x006BD070 File Offset: 0x006BB270
		public static IInteractActions GetRootAsIInteractActions(ByteBuffer _bb)
		{
			return IInteractActions.GetRootAsIInteractActions(_bb, default(IInteractActions));
		}

		// Token: 0x06031C6B RID: 203883 RVA: 0x006BD08C File Offset: 0x006BB28C
		public static IInteractActions GetRootAsIInteractActions(ByteBuffer _bb, IInteractActions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031C6C RID: 203884 RVA: 0x006BD0A9 File Offset: 0x006BB2A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031C6D RID: 203885 RVA: 0x006BD0B8 File Offset: 0x006BB2B8
		public IInteractActions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D24E RID: 53838
		// (get) Token: 0x06031C6E RID: 203886 RVA: 0x006BD0C8 File Offset: 0x006BB2C8
		public EInteractOption Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractOption.Flow;
				}
				return (EInteractOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031C6F RID: 203887 RVA: 0x006BD104 File Offset: 0x006BB304
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D24F RID: 53839
		// (get) Token: 0x06031C70 RID: 203888 RVA: 0x006BD164 File Offset: 0x006BB364
		public int ActionsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06031C71 RID: 203889 RVA: 0x006BD18F File Offset: 0x006BB38F
		public static Offset<IInteractActions> CreateIInteractActions(FlatBufferBuilder builder, EInteractOption Type = EInteractOption.Flow, VectorOffset ActionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IInteractActions.AddActions(builder, ActionsOffset);
			IInteractActions.AddType(builder, Type);
			return IInteractActions.EndIInteractActions(builder);
		}

		// Token: 0x06031C72 RID: 203890 RVA: 0x006BD1AC File Offset: 0x006BB3AC
		public static void StartIInteractActions(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031C73 RID: 203891 RVA: 0x006BD1B5 File Offset: 0x006BB3B5
		public static void AddType(FlatBufferBuilder builder, EInteractOption type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031C74 RID: 203892 RVA: 0x006BD1C0 File Offset: 0x006BB3C0
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x06031C75 RID: 203893 RVA: 0x006BD1D0 File Offset: 0x006BB3D0
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06031C76 RID: 203894 RVA: 0x006BD210 File Offset: 0x006BB410
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06031C77 RID: 203895 RVA: 0x006BD22A File Offset: 0x006BB42A
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06031C78 RID: 203896 RVA: 0x006BD248 File Offset: 0x006BB448
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031C79 RID: 203897 RVA: 0x006BD261 File Offset: 0x006BB461
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031C7A RID: 203898 RVA: 0x006BD26C File Offset: 0x006BB46C
		public static Offset<IInteractActions> EndIInteractActions(FlatBufferBuilder builder)
		{
			return new Offset<IInteractActions>(builder.EndTable());
		}

		// Token: 0x06031C7B RID: 203899 RVA: 0x006BD27C File Offset: 0x006BB47C
		public IInteractActionsT UnPack()
		{
			IInteractActionsT interactActionsT = new IInteractActionsT();
			this.UnPackTo(interactActionsT);
			return interactActionsT;
		}

		// Token: 0x06031C7C RID: 203900 RVA: 0x006BD298 File Offset: 0x006BB498
		public void UnPackTo(IInteractActionsT _o)
		{
			_o.Type = this.Type;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06031C7D RID: 203901 RVA: 0x006BD304 File Offset: 0x006BB504
		public static Offset<IInteractActions> Pack(FlatBufferBuilder builder, IInteractActionsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractActions>);
			}
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IInteractActions.CreateActionsVector(builder, array);
			}
			return IInteractActions.CreateIInteractActions(builder, _o.Type, actionsOffset);
		}

		// Token: 0x04011F71 RID: 73585
		private Table __p;
	}
}
