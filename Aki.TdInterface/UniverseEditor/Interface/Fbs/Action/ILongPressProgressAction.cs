using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A53 RID: 27219
	public struct ILongPressProgressAction : IFlatbufferObject
	{
		// Token: 0x1700C9EC RID: 51692
		// (get) Token: 0x0602FA82 RID: 195202 RVA: 0x0067C73D File Offset: 0x0067A93D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FA83 RID: 195203 RVA: 0x0067C74A File Offset: 0x0067A94A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FA84 RID: 195204 RVA: 0x0067C754 File Offset: 0x0067A954
		public static ILongPressProgressAction GetRootAsILongPressProgressAction(ByteBuffer _bb)
		{
			return ILongPressProgressAction.GetRootAsILongPressProgressAction(_bb, default(ILongPressProgressAction));
		}

		// Token: 0x0602FA85 RID: 195205 RVA: 0x0067C770 File Offset: 0x0067A970
		public static ILongPressProgressAction GetRootAsILongPressProgressAction(ByteBuffer _bb, ILongPressProgressAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FA86 RID: 195206 RVA: 0x0067C78D File Offset: 0x0067A98D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FA87 RID: 195207 RVA: 0x0067C79C File Offset: 0x0067A99C
		public ILongPressProgressAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9ED RID: 51693
		// (get) Token: 0x0602FA88 RID: 195208 RVA: 0x0067C7AC File Offset: 0x0067A9AC
		public float Percentage
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FA89 RID: 195209 RVA: 0x0067C7EC File Offset: 0x0067A9EC
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C9EE RID: 51694
		// (get) Token: 0x0602FA8A RID: 195210 RVA: 0x0067C84C File Offset: 0x0067AA4C
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

		// Token: 0x0602FA8B RID: 195211 RVA: 0x0067C877 File Offset: 0x0067AA77
		public static Offset<ILongPressProgressAction> CreateILongPressProgressAction(FlatBufferBuilder builder, float Percentage = 0f, VectorOffset ActionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ILongPressProgressAction.AddActions(builder, ActionsOffset);
			ILongPressProgressAction.AddPercentage(builder, Percentage);
			return ILongPressProgressAction.EndILongPressProgressAction(builder);
		}

		// Token: 0x0602FA8C RID: 195212 RVA: 0x0067C894 File Offset: 0x0067AA94
		public static void StartILongPressProgressAction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FA8D RID: 195213 RVA: 0x0067C89D File Offset: 0x0067AA9D
		public static void AddPercentage(FlatBufferBuilder builder, float percentage)
		{
			builder.AddFloat(0, percentage, 0.0);
		}

		// Token: 0x0602FA8E RID: 195214 RVA: 0x0067C8B0 File Offset: 0x0067AAB0
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x0602FA8F RID: 195215 RVA: 0x0067C8C0 File Offset: 0x0067AAC0
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602FA90 RID: 195216 RVA: 0x0067C900 File Offset: 0x0067AB00
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FA91 RID: 195217 RVA: 0x0067C91A File Offset: 0x0067AB1A
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FA92 RID: 195218 RVA: 0x0067C938 File Offset: 0x0067AB38
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602FA93 RID: 195219 RVA: 0x0067C951 File Offset: 0x0067AB51
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602FA94 RID: 195220 RVA: 0x0067C95C File Offset: 0x0067AB5C
		public static Offset<ILongPressProgressAction> EndILongPressProgressAction(FlatBufferBuilder builder)
		{
			return new Offset<ILongPressProgressAction>(builder.EndTable());
		}

		// Token: 0x0602FA95 RID: 195221 RVA: 0x0067C96C File Offset: 0x0067AB6C
		public ILongPressProgressActionT UnPack()
		{
			ILongPressProgressActionT longPressProgressActionT = new ILongPressProgressActionT();
			this.UnPackTo(longPressProgressActionT);
			return longPressProgressActionT;
		}

		// Token: 0x0602FA96 RID: 195222 RVA: 0x0067C988 File Offset: 0x0067AB88
		public void UnPackTo(ILongPressProgressActionT _o)
		{
			_o.Percentage = this.Percentage;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602FA97 RID: 195223 RVA: 0x0067C9F4 File Offset: 0x0067ABF4
		public static Offset<ILongPressProgressAction> Pack(FlatBufferBuilder builder, ILongPressProgressActionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILongPressProgressAction>);
			}
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = ILongPressProgressAction.CreateActionsVector(builder, array);
			}
			return ILongPressProgressAction.CreateILongPressProgressAction(builder, _o.Percentage, actionsOffset);
		}

		// Token: 0x04011272 RID: 70258
		private Table __p;
	}
}
