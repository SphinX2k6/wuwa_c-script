using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061D4 RID: 25044
	public struct IWuWaGoInteractStateAction : IFlatbufferObject
	{
		// Token: 0x1700BAB8 RID: 47800
		// (get) Token: 0x0602A943 RID: 174403 RVA: 0x005CE4EC File Offset: 0x005CC6EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A944 RID: 174404 RVA: 0x005CE4F9 File Offset: 0x005CC6F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A945 RID: 174405 RVA: 0x005CE500 File Offset: 0x005CC700
		public static IWuWaGoInteractStateAction GetRootAsIWuWaGoInteractStateAction(ByteBuffer _bb)
		{
			return IWuWaGoInteractStateAction.GetRootAsIWuWaGoInteractStateAction(_bb, default(IWuWaGoInteractStateAction));
		}

		// Token: 0x0602A946 RID: 174406 RVA: 0x005CE51C File Offset: 0x005CC71C
		public static IWuWaGoInteractStateAction GetRootAsIWuWaGoInteractStateAction(ByteBuffer _bb, IWuWaGoInteractStateAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A947 RID: 174407 RVA: 0x005CE539 File Offset: 0x005CC739
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A948 RID: 174408 RVA: 0x005CE548 File Offset: 0x005CC748
		public IWuWaGoInteractStateAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BAB9 RID: 47801
		// (get) Token: 0x0602A949 RID: 174409 RVA: 0x005CE558 File Offset: 0x005CC758
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

		// Token: 0x0602A94A RID: 174410 RVA: 0x005CE58F File Offset: 0x005CC78F
		public Span<byte> GetEntityStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602A94B RID: 174411 RVA: 0x005CE59E File Offset: 0x005CC79E
		public byte[] GetEntityStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602A94C RID: 174412 RVA: 0x005CE5AC File Offset: 0x005CC7AC
		public IActionInfo? ActionList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BABA RID: 47802
		// (get) Token: 0x0602A94D RID: 174413 RVA: 0x005CE60C File Offset: 0x005CC80C
		public int ActionListLength
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

		// Token: 0x0602A94E RID: 174414 RVA: 0x005CE637 File Offset: 0x005CC837
		public static Offset<IWuWaGoInteractStateAction> CreateIWuWaGoInteractStateAction(FlatBufferBuilder builder, StringOffset EntityStateOffset = default(StringOffset), VectorOffset ActionListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IWuWaGoInteractStateAction.AddActionList(builder, ActionListOffset);
			IWuWaGoInteractStateAction.AddEntityState(builder, EntityStateOffset);
			return IWuWaGoInteractStateAction.EndIWuWaGoInteractStateAction(builder);
		}

		// Token: 0x0602A94F RID: 174415 RVA: 0x005CE654 File Offset: 0x005CC854
		public static void StartIWuWaGoInteractStateAction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A950 RID: 174416 RVA: 0x005CE65D File Offset: 0x005CC85D
		public static void AddEntityState(FlatBufferBuilder builder, StringOffset entityStateOffset)
		{
			builder.AddOffset(0, entityStateOffset.Value, 0);
		}

		// Token: 0x0602A951 RID: 174417 RVA: 0x005CE66D File Offset: 0x005CC86D
		public static void AddActionList(FlatBufferBuilder builder, VectorOffset actionListOffset)
		{
			builder.AddOffset(1, actionListOffset.Value, 0);
		}

		// Token: 0x0602A952 RID: 174418 RVA: 0x005CE680 File Offset: 0x005CC880
		public static VectorOffset CreateActionListVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A953 RID: 174419 RVA: 0x005CE6C0 File Offset: 0x005CC8C0
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A954 RID: 174420 RVA: 0x005CE6DA File Offset: 0x005CC8DA
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A955 RID: 174421 RVA: 0x005CE6F8 File Offset: 0x005CC8F8
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A956 RID: 174422 RVA: 0x005CE711 File Offset: 0x005CC911
		public static void StartActionListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A957 RID: 174423 RVA: 0x005CE71C File Offset: 0x005CC91C
		public static Offset<IWuWaGoInteractStateAction> EndIWuWaGoInteractStateAction(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoInteractStateAction>(builder.EndTable());
		}

		// Token: 0x0602A958 RID: 174424 RVA: 0x005CE72C File Offset: 0x005CC92C
		public IWuWaGoInteractStateActionT UnPack()
		{
			IWuWaGoInteractStateActionT wuWaGoInteractStateActionT = new IWuWaGoInteractStateActionT();
			this.UnPackTo(wuWaGoInteractStateActionT);
			return wuWaGoInteractStateActionT;
		}

		// Token: 0x0602A959 RID: 174425 RVA: 0x005CE748 File Offset: 0x005CC948
		public void UnPackTo(IWuWaGoInteractStateActionT _o)
		{
			_o.EntityState = this.EntityState;
			_o.ActionList = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionListLength; i++)
			{
				_o.ActionList.Add((this.ActionList(i) != null) ? this.ActionList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602A95A RID: 174426 RVA: 0x005CE7B4 File Offset: 0x005CC9B4
		public static Offset<IWuWaGoInteractStateAction> Pack(FlatBufferBuilder builder, IWuWaGoInteractStateActionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoInteractStateAction>);
			}
			StringOffset entityStateOffset = (_o.EntityState == null) ? default(StringOffset) : builder.CreateString(_o.EntityState);
			VectorOffset actionListOffset = default(VectorOffset);
			if (_o.ActionList != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.ActionList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.ActionList[i]);
				}
				actionListOffset = IWuWaGoInteractStateAction.CreateActionListVector(builder, array);
			}
			return IWuWaGoInteractStateAction.CreateIWuWaGoInteractStateAction(builder, entityStateOffset, actionListOffset);
		}

		// Token: 0x0401003C RID: 65596
		private Table __p;
	}
}
