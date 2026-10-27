using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005858 RID: 22616
	public struct IRenjuConfig : IFlatbufferObject
	{
		// Token: 0x1700A900 RID: 43264
		// (get) Token: 0x06026109 RID: 155913 RVA: 0x0053F715 File Offset: 0x0053D915
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602610A RID: 155914 RVA: 0x0053F722 File Offset: 0x0053D922
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602610B RID: 155915 RVA: 0x0053F72C File Offset: 0x0053D92C
		public static IRenjuConfig GetRootAsIRenjuConfig(ByteBuffer _bb)
		{
			return IRenjuConfig.GetRootAsIRenjuConfig(_bb, default(IRenjuConfig));
		}

		// Token: 0x0602610C RID: 155916 RVA: 0x0053F748 File Offset: 0x0053D948
		public static IRenjuConfig GetRootAsIRenjuConfig(ByteBuffer _bb, IRenjuConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602610D RID: 155917 RVA: 0x0053F765 File Offset: 0x0053D965
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602610E RID: 155918 RVA: 0x0053F774 File Offset: 0x0053D974
		public IRenjuConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A901 RID: 43265
		// (get) Token: 0x0602610F RID: 155919 RVA: 0x0053F784 File Offset: 0x0053D984
		public ERenjuController Controller
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERenjuController.Computer;
				}
				return (ERenjuController)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A902 RID: 43266
		// (get) Token: 0x06026110 RID: 155920 RVA: 0x0053F7C0 File Offset: 0x0053D9C0
		public ERenjuOrder Order
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ERenjuOrder.Order0;
				}
				return (ERenjuOrder)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A903 RID: 43267
		// (get) Token: 0x06026111 RID: 155921 RVA: 0x0053F7FC File Offset: 0x0053D9FC
		public int RenjuCount
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026112 RID: 155922 RVA: 0x0053F838 File Offset: 0x0053DA38
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A904 RID: 43268
		// (get) Token: 0x06026113 RID: 155923 RVA: 0x0053F878 File Offset: 0x0053DA78
		public int EntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06026114 RID: 155924 RVA: 0x0053F8A4 File Offset: 0x0053DAA4
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06026115 RID: 155925 RVA: 0x0053F8B4 File Offset: 0x0053DAB4
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x06026116 RID: 155926 RVA: 0x0053F8C4 File Offset: 0x0053DAC4
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A905 RID: 43269
		// (get) Token: 0x06026117 RID: 155927 RVA: 0x0053F928 File Offset: 0x0053DB28
		public int ActionsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A906 RID: 43270
		// (get) Token: 0x06026118 RID: 155928 RVA: 0x0053F954 File Offset: 0x0053DB54
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026119 RID: 155929 RVA: 0x0053F991 File Offset: 0x0053DB91
		public static Offset<IRenjuConfig> CreateIRenjuConfig(FlatBufferBuilder builder, ERenjuController Controller = ERenjuController.Computer, ERenjuOrder Order = ERenjuOrder.Order0, int RenjuCount = 0, VectorOffset EntityIdsOffset = default(VectorOffset), VectorOffset ActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IRenjuConfig.AddActions(builder, ActionsOffset);
			IRenjuConfig.AddEntityIds(builder, EntityIdsOffset);
			IRenjuConfig.AddRenjuCount(builder, RenjuCount);
			IRenjuConfig.AddNullMask(builder, NullMask);
			IRenjuConfig.AddOrder(builder, Order);
			IRenjuConfig.AddController(builder, Controller);
			return IRenjuConfig.EndIRenjuConfig(builder);
		}

		// Token: 0x0602611A RID: 155930 RVA: 0x0053F9CD File Offset: 0x0053DBCD
		public static void StartIRenjuConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602611B RID: 155931 RVA: 0x0053F9D6 File Offset: 0x0053DBD6
		public static void AddController(FlatBufferBuilder builder, ERenjuController controller)
		{
			builder.AddByte(0, (byte)controller, 0);
		}

		// Token: 0x0602611C RID: 155932 RVA: 0x0053F9E1 File Offset: 0x0053DBE1
		public static void AddOrder(FlatBufferBuilder builder, ERenjuOrder order)
		{
			builder.AddByte(1, (byte)order, 0);
		}

		// Token: 0x0602611D RID: 155933 RVA: 0x0053F9EC File Offset: 0x0053DBEC
		public static void AddRenjuCount(FlatBufferBuilder builder, int renjuCount)
		{
			builder.AddInt(2, renjuCount, 0);
		}

		// Token: 0x0602611E RID: 155934 RVA: 0x0053F9F7 File Offset: 0x0053DBF7
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(3, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602611F RID: 155935 RVA: 0x0053FA08 File Offset: 0x0053DC08
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06026120 RID: 155936 RVA: 0x0053FA3F File Offset: 0x0053DC3F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026121 RID: 155937 RVA: 0x0053FA59 File Offset: 0x0053DC59
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026122 RID: 155938 RVA: 0x0053FA77 File Offset: 0x0053DC77
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026123 RID: 155939 RVA: 0x0053FA90 File Offset: 0x0053DC90
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026124 RID: 155940 RVA: 0x0053FA9B File Offset: 0x0053DC9B
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(4, actionsOffset.Value, 0);
		}

		// Token: 0x06026125 RID: 155941 RVA: 0x0053FAAC File Offset: 0x0053DCAC
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026126 RID: 155942 RVA: 0x0053FAEC File Offset: 0x0053DCEC
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026127 RID: 155943 RVA: 0x0053FB06 File Offset: 0x0053DD06
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026128 RID: 155944 RVA: 0x0053FB24 File Offset: 0x0053DD24
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026129 RID: 155945 RVA: 0x0053FB3D File Offset: 0x0053DD3D
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602612A RID: 155946 RVA: 0x0053FB48 File Offset: 0x0053DD48
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602612B RID: 155947 RVA: 0x0053FB53 File Offset: 0x0053DD53
		public static Offset<IRenjuConfig> EndIRenjuConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRenjuConfig>(builder.EndTable());
		}

		// Token: 0x0602612C RID: 155948 RVA: 0x0053FB60 File Offset: 0x0053DD60
		public IRenjuConfigT UnPack()
		{
			IRenjuConfigT renjuConfigT = new IRenjuConfigT();
			this.UnPackTo(renjuConfigT);
			return renjuConfigT;
		}

		// Token: 0x0602612D RID: 155949 RVA: 0x0053FB7C File Offset: 0x0053DD7C
		public void UnPackTo(IRenjuConfigT _o)
		{
			_o.Controller = this.Controller;
			_o.Order = this.Order;
			_o.RenjuCount = this.RenjuCount;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.Actions = new List<IActionInfoT>();
			for (int j = 0; j < this.ActionsLength; j++)
			{
				_o.Actions.Add((this.Actions(j) != null) ? this.Actions(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602612E RID: 155950 RVA: 0x0053FC3C File Offset: 0x0053DE3C
		public static Offset<IRenjuConfig> Pack(FlatBufferBuilder builder, IRenjuConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRenjuConfig>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IRenjuConfig.CreateEntityIdsVector(builder, data);
			}
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IRenjuConfig.CreateActionsVector(builder, array);
			}
			return IRenjuConfig.CreateIRenjuConfig(builder, _o.Controller, _o.Order, _o.RenjuCount, entityIdsOffset, actionsOffset, _o.NullMask);
		}

		// Token: 0x0400ED84 RID: 60804
		private Table __p;
	}
}
