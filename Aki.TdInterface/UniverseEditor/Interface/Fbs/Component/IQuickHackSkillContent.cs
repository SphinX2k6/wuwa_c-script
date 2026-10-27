using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057D2 RID: 22482
	public struct IQuickHackSkillContent : IFlatbufferObject
	{
		// Token: 0x1700A7D7 RID: 42967
		// (get) Token: 0x06025BEE RID: 154606 RVA: 0x00534924 File Offset: 0x00532B24
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025BEF RID: 154607 RVA: 0x00534931 File Offset: 0x00532B31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025BF0 RID: 154608 RVA: 0x00534938 File Offset: 0x00532B38
		public static IQuickHackSkillContent GetRootAsIQuickHackSkillContent(ByteBuffer _bb)
		{
			return IQuickHackSkillContent.GetRootAsIQuickHackSkillContent(_bb, default(IQuickHackSkillContent));
		}

		// Token: 0x06025BF1 RID: 154609 RVA: 0x00534954 File Offset: 0x00532B54
		public static IQuickHackSkillContent GetRootAsIQuickHackSkillContent(ByteBuffer _bb, IQuickHackSkillContent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025BF2 RID: 154610 RVA: 0x00534971 File Offset: 0x00532B71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025BF3 RID: 154611 RVA: 0x00534980 File Offset: 0x00532B80
		public IQuickHackSkillContent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A7D8 RID: 42968
		// (get) Token: 0x06025BF4 RID: 154612 RVA: 0x00534990 File Offset: 0x00532B90
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

		// Token: 0x06025BF5 RID: 154613 RVA: 0x005349C7 File Offset: 0x00532BC7
		public Span<byte> GetEntityStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06025BF6 RID: 154614 RVA: 0x005349D6 File Offset: 0x00532BD6
		public byte[] GetEntityStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06025BF7 RID: 154615 RVA: 0x005349E4 File Offset: 0x00532BE4
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A7D9 RID: 42969
		// (get) Token: 0x06025BF8 RID: 154616 RVA: 0x00534A44 File Offset: 0x00532C44
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

		// Token: 0x06025BF9 RID: 154617 RVA: 0x00534A6F File Offset: 0x00532C6F
		public static Offset<IQuickHackSkillContent> CreateIQuickHackSkillContent(FlatBufferBuilder builder, StringOffset EntityStateOffset = default(StringOffset), VectorOffset ActionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IQuickHackSkillContent.AddActions(builder, ActionsOffset);
			IQuickHackSkillContent.AddEntityState(builder, EntityStateOffset);
			return IQuickHackSkillContent.EndIQuickHackSkillContent(builder);
		}

		// Token: 0x06025BFA RID: 154618 RVA: 0x00534A8C File Offset: 0x00532C8C
		public static void StartIQuickHackSkillContent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025BFB RID: 154619 RVA: 0x00534A95 File Offset: 0x00532C95
		public static void AddEntityState(FlatBufferBuilder builder, StringOffset entityStateOffset)
		{
			builder.AddOffset(0, entityStateOffset.Value, 0);
		}

		// Token: 0x06025BFC RID: 154620 RVA: 0x00534AA5 File Offset: 0x00532CA5
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x06025BFD RID: 154621 RVA: 0x00534AB8 File Offset: 0x00532CB8
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025BFE RID: 154622 RVA: 0x00534AF8 File Offset: 0x00532CF8
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025BFF RID: 154623 RVA: 0x00534B12 File Offset: 0x00532D12
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025C00 RID: 154624 RVA: 0x00534B30 File Offset: 0x00532D30
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025C01 RID: 154625 RVA: 0x00534B49 File Offset: 0x00532D49
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025C02 RID: 154626 RVA: 0x00534B54 File Offset: 0x00532D54
		public static Offset<IQuickHackSkillContent> EndIQuickHackSkillContent(FlatBufferBuilder builder)
		{
			return new Offset<IQuickHackSkillContent>(builder.EndTable());
		}

		// Token: 0x06025C03 RID: 154627 RVA: 0x00534B64 File Offset: 0x00532D64
		public IQuickHackSkillContentT UnPack()
		{
			IQuickHackSkillContentT quickHackSkillContentT = new IQuickHackSkillContentT();
			this.UnPackTo(quickHackSkillContentT);
			return quickHackSkillContentT;
		}

		// Token: 0x06025C04 RID: 154628 RVA: 0x00534B80 File Offset: 0x00532D80
		public void UnPackTo(IQuickHackSkillContentT _o)
		{
			_o.EntityState = this.EntityState;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06025C05 RID: 154629 RVA: 0x00534BEC File Offset: 0x00532DEC
		public static Offset<IQuickHackSkillContent> Pack(FlatBufferBuilder builder, IQuickHackSkillContentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuickHackSkillContent>);
			}
			StringOffset entityStateOffset = (_o.EntityState == null) ? default(StringOffset) : builder.CreateString(_o.EntityState);
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IQuickHackSkillContent.CreateActionsVector(builder, array);
			}
			return IQuickHackSkillContent.CreateIQuickHackSkillContent(builder, entityStateOffset, actionsOffset);
		}

		// Token: 0x0400ECB7 RID: 60599
		private Table __p;
	}
}
