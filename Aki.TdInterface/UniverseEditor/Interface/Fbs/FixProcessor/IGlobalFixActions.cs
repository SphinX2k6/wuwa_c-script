using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004BC5 RID: 19397
	public struct IGlobalFixActions : IFlatbufferObject
	{
		// Token: 0x17008956 RID: 35158
		// (get) Token: 0x0601D9CA RID: 121290 RVA: 0x004282E0 File Offset: 0x004264E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D9CB RID: 121291 RVA: 0x004282ED File Offset: 0x004264ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D9CC RID: 121292 RVA: 0x004282F4 File Offset: 0x004264F4
		public static IGlobalFixActions GetRootAsIGlobalFixActions(ByteBuffer _bb)
		{
			return IGlobalFixActions.GetRootAsIGlobalFixActions(_bb, default(IGlobalFixActions));
		}

		// Token: 0x0601D9CD RID: 121293 RVA: 0x00428310 File Offset: 0x00426510
		public static IGlobalFixActions GetRootAsIGlobalFixActions(ByteBuffer _bb, IGlobalFixActions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D9CE RID: 121294 RVA: 0x0042832D File Offset: 0x0042652D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D9CF RID: 121295 RVA: 0x0042833C File Offset: 0x0042653C
		public IGlobalFixActions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601D9D0 RID: 121296 RVA: 0x0042834C File Offset: 0x0042654C
		public IActionInfo? ActionList(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008957 RID: 35159
		// (get) Token: 0x0601D9D1 RID: 121297 RVA: 0x004283AC File Offset: 0x004265AC
		public int ActionListLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601D9D2 RID: 121298 RVA: 0x004283D7 File Offset: 0x004265D7
		public static Offset<IGlobalFixActions> CreateIGlobalFixActions(FlatBufferBuilder builder, VectorOffset ActionListOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IGlobalFixActions.AddActionList(builder, ActionListOffset);
			return IGlobalFixActions.EndIGlobalFixActions(builder);
		}

		// Token: 0x0601D9D3 RID: 121299 RVA: 0x004283ED File Offset: 0x004265ED
		public static void StartIGlobalFixActions(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601D9D4 RID: 121300 RVA: 0x004283F6 File Offset: 0x004265F6
		public static void AddActionList(FlatBufferBuilder builder, VectorOffset actionListOffset)
		{
			builder.AddOffset(0, actionListOffset.Value, 0);
		}

		// Token: 0x0601D9D5 RID: 121301 RVA: 0x00428408 File Offset: 0x00426608
		public static VectorOffset CreateActionListVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D9D6 RID: 121302 RVA: 0x00428448 File Offset: 0x00426648
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D9D7 RID: 121303 RVA: 0x00428462 File Offset: 0x00426662
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D9D8 RID: 121304 RVA: 0x00428480 File Offset: 0x00426680
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D9D9 RID: 121305 RVA: 0x00428499 File Offset: 0x00426699
		public static void StartActionListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D9DA RID: 121306 RVA: 0x004284A4 File Offset: 0x004266A4
		public static Offset<IGlobalFixActions> EndIGlobalFixActions(FlatBufferBuilder builder)
		{
			return new Offset<IGlobalFixActions>(builder.EndTable());
		}

		// Token: 0x0601D9DB RID: 121307 RVA: 0x004284B4 File Offset: 0x004266B4
		public IGlobalFixActionsT UnPack()
		{
			IGlobalFixActionsT globalFixActionsT = new IGlobalFixActionsT();
			this.UnPackTo(globalFixActionsT);
			return globalFixActionsT;
		}

		// Token: 0x0601D9DC RID: 121308 RVA: 0x004284D0 File Offset: 0x004266D0
		public void UnPackTo(IGlobalFixActionsT _o)
		{
			_o.ActionList = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionListLength; i++)
			{
				_o.ActionList.Add((this.ActionList(i) != null) ? this.ActionList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601D9DD RID: 121309 RVA: 0x00428530 File Offset: 0x00426730
		public static Offset<IGlobalFixActions> Pack(FlatBufferBuilder builder, IGlobalFixActionsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGlobalFixActions>);
			}
			VectorOffset actionListOffset = default(VectorOffset);
			if (_o.ActionList != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.ActionList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.ActionList[i]);
				}
				actionListOffset = IGlobalFixActions.CreateActionListVector(builder, array);
			}
			return IGlobalFixActions.CreateIGlobalFixActions(builder, actionListOffset);
		}

		// Token: 0x0400D48D RID: 54413
		private Table __p;
	}
}
