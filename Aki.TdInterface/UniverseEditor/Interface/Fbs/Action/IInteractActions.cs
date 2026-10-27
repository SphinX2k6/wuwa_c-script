using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200697E RID: 27006
	public struct IInteractActions : IFlatbufferObject
	{
		// Token: 0x1700C84A RID: 51274
		// (get) Token: 0x0602F298 RID: 193176 RVA: 0x0066CB71 File Offset: 0x0066AD71
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F299 RID: 193177 RVA: 0x0066CB7E File Offset: 0x0066AD7E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F29A RID: 193178 RVA: 0x0066CB88 File Offset: 0x0066AD88
		public static IInteractActions GetRootAsIInteractActions(ByteBuffer _bb)
		{
			return IInteractActions.GetRootAsIInteractActions(_bb, default(IInteractActions));
		}

		// Token: 0x0602F29B RID: 193179 RVA: 0x0066CBA4 File Offset: 0x0066ADA4
		public static IInteractActions GetRootAsIInteractActions(ByteBuffer _bb, IInteractActions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F29C RID: 193180 RVA: 0x0066CBC1 File Offset: 0x0066ADC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F29D RID: 193181 RVA: 0x0066CBD0 File Offset: 0x0066ADD0
		public IInteractActions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C84B RID: 51275
		// (get) Token: 0x0602F29E RID: 193182 RVA: 0x0066CBE0 File Offset: 0x0066ADE0
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

		// Token: 0x0602F29F RID: 193183 RVA: 0x0066CC1C File Offset: 0x0066AE1C
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C84C RID: 51276
		// (get) Token: 0x0602F2A0 RID: 193184 RVA: 0x0066CC7C File Offset: 0x0066AE7C
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

		// Token: 0x0602F2A1 RID: 193185 RVA: 0x0066CCA7 File Offset: 0x0066AEA7
		public static Offset<IInteractActions> CreateIInteractActions(FlatBufferBuilder builder, EInteractOption Type = EInteractOption.Flow, VectorOffset ActionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IInteractActions.AddActions(builder, ActionsOffset);
			IInteractActions.AddType(builder, Type);
			return IInteractActions.EndIInteractActions(builder);
		}

		// Token: 0x0602F2A2 RID: 193186 RVA: 0x0066CCC4 File Offset: 0x0066AEC4
		public static void StartIInteractActions(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F2A3 RID: 193187 RVA: 0x0066CCCD File Offset: 0x0066AECD
		public static void AddType(FlatBufferBuilder builder, EInteractOption type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F2A4 RID: 193188 RVA: 0x0066CCD8 File Offset: 0x0066AED8
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x0602F2A5 RID: 193189 RVA: 0x0066CCE8 File Offset: 0x0066AEE8
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F2A6 RID: 193190 RVA: 0x0066CD28 File Offset: 0x0066AF28
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F2A7 RID: 193191 RVA: 0x0066CD42 File Offset: 0x0066AF42
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F2A8 RID: 193192 RVA: 0x0066CD60 File Offset: 0x0066AF60
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F2A9 RID: 193193 RVA: 0x0066CD79 File Offset: 0x0066AF79
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F2AA RID: 193194 RVA: 0x0066CD84 File Offset: 0x0066AF84
		public static Offset<IInteractActions> EndIInteractActions(FlatBufferBuilder builder)
		{
			return new Offset<IInteractActions>(builder.EndTable());
		}

		// Token: 0x0602F2AB RID: 193195 RVA: 0x0066CD94 File Offset: 0x0066AF94
		public IInteractActionsT UnPack()
		{
			IInteractActionsT interactActionsT = new IInteractActionsT();
			this.UnPackTo(interactActionsT);
			return interactActionsT;
		}

		// Token: 0x0602F2AC RID: 193196 RVA: 0x0066CDB0 File Offset: 0x0066AFB0
		public void UnPackTo(IInteractActionsT _o)
		{
			_o.Type = this.Type;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602F2AD RID: 193197 RVA: 0x0066CE1C File Offset: 0x0066B01C
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

		// Token: 0x04011105 RID: 69893
		private Table __p;
	}
}
