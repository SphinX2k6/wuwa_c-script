using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DD9 RID: 24025
	public struct IQuickHackSkillContent : IFlatbufferObject
	{
		// Token: 0x1700B0FB RID: 45307
		// (get) Token: 0x0602810E RID: 164110 RVA: 0x0057AAB0 File Offset: 0x00578CB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602810F RID: 164111 RVA: 0x0057AABD File Offset: 0x00578CBD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028110 RID: 164112 RVA: 0x0057AAC4 File Offset: 0x00578CC4
		public static IQuickHackSkillContent GetRootAsIQuickHackSkillContent(ByteBuffer _bb)
		{
			return IQuickHackSkillContent.GetRootAsIQuickHackSkillContent(_bb, default(IQuickHackSkillContent));
		}

		// Token: 0x06028111 RID: 164113 RVA: 0x0057AAE0 File Offset: 0x00578CE0
		public static IQuickHackSkillContent GetRootAsIQuickHackSkillContent(ByteBuffer _bb, IQuickHackSkillContent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028112 RID: 164114 RVA: 0x0057AAFD File Offset: 0x00578CFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028113 RID: 164115 RVA: 0x0057AB0C File Offset: 0x00578D0C
		public IQuickHackSkillContent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B0FC RID: 45308
		// (get) Token: 0x06028114 RID: 164116 RVA: 0x0057AB1C File Offset: 0x00578D1C
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

		// Token: 0x06028115 RID: 164117 RVA: 0x0057AB53 File Offset: 0x00578D53
		public Span<byte> GetEntityStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06028116 RID: 164118 RVA: 0x0057AB62 File Offset: 0x00578D62
		public byte[] GetEntityStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06028117 RID: 164119 RVA: 0x0057AB70 File Offset: 0x00578D70
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B0FD RID: 45309
		// (get) Token: 0x06028118 RID: 164120 RVA: 0x0057ABD0 File Offset: 0x00578DD0
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

		// Token: 0x06028119 RID: 164121 RVA: 0x0057ABFB File Offset: 0x00578DFB
		public static Offset<IQuickHackSkillContent> CreateIQuickHackSkillContent(FlatBufferBuilder builder, StringOffset EntityStateOffset = default(StringOffset), VectorOffset ActionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IQuickHackSkillContent.AddActions(builder, ActionsOffset);
			IQuickHackSkillContent.AddEntityState(builder, EntityStateOffset);
			return IQuickHackSkillContent.EndIQuickHackSkillContent(builder);
		}

		// Token: 0x0602811A RID: 164122 RVA: 0x0057AC18 File Offset: 0x00578E18
		public static void StartIQuickHackSkillContent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602811B RID: 164123 RVA: 0x0057AC21 File Offset: 0x00578E21
		public static void AddEntityState(FlatBufferBuilder builder, StringOffset entityStateOffset)
		{
			builder.AddOffset(0, entityStateOffset.Value, 0);
		}

		// Token: 0x0602811C RID: 164124 RVA: 0x0057AC31 File Offset: 0x00578E31
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x0602811D RID: 164125 RVA: 0x0057AC44 File Offset: 0x00578E44
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602811E RID: 164126 RVA: 0x0057AC84 File Offset: 0x00578E84
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602811F RID: 164127 RVA: 0x0057AC9E File Offset: 0x00578E9E
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028120 RID: 164128 RVA: 0x0057ACBC File Offset: 0x00578EBC
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028121 RID: 164129 RVA: 0x0057ACD5 File Offset: 0x00578ED5
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028122 RID: 164130 RVA: 0x0057ACE0 File Offset: 0x00578EE0
		public static Offset<IQuickHackSkillContent> EndIQuickHackSkillContent(FlatBufferBuilder builder)
		{
			return new Offset<IQuickHackSkillContent>(builder.EndTable());
		}

		// Token: 0x06028123 RID: 164131 RVA: 0x0057ACF0 File Offset: 0x00578EF0
		public IQuickHackSkillContentT UnPack()
		{
			IQuickHackSkillContentT quickHackSkillContentT = new IQuickHackSkillContentT();
			this.UnPackTo(quickHackSkillContentT);
			return quickHackSkillContentT;
		}

		// Token: 0x06028124 RID: 164132 RVA: 0x0057AD0C File Offset: 0x00578F0C
		public void UnPackTo(IQuickHackSkillContentT _o)
		{
			_o.EntityState = this.EntityState;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06028125 RID: 164133 RVA: 0x0057AD78 File Offset: 0x00578F78
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

		// Token: 0x0400F9A2 RID: 63906
		private Table __p;
	}
}
