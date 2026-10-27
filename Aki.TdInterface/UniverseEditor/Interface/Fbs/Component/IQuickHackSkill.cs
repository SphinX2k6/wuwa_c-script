using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057CF RID: 22479
	public struct IQuickHackSkill : IFlatbufferObject
	{
		// Token: 0x1700A7D2 RID: 42962
		// (get) Token: 0x06025BD2 RID: 154578 RVA: 0x00534576 File Offset: 0x00532776
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025BD3 RID: 154579 RVA: 0x00534583 File Offset: 0x00532783
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025BD4 RID: 154580 RVA: 0x0053458C File Offset: 0x0053278C
		public static IQuickHackSkill GetRootAsIQuickHackSkill(ByteBuffer _bb)
		{
			return IQuickHackSkill.GetRootAsIQuickHackSkill(_bb, default(IQuickHackSkill));
		}

		// Token: 0x06025BD5 RID: 154581 RVA: 0x005345A8 File Offset: 0x005327A8
		public static IQuickHackSkill GetRootAsIQuickHackSkill(ByteBuffer _bb, IQuickHackSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025BD6 RID: 154582 RVA: 0x005345C5 File Offset: 0x005327C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025BD7 RID: 154583 RVA: 0x005345D4 File Offset: 0x005327D4
		public IQuickHackSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A7D3 RID: 42963
		// (get) Token: 0x06025BD8 RID: 154584 RVA: 0x005345E4 File Offset: 0x005327E4
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025BD9 RID: 154585 RVA: 0x00534620 File Offset: 0x00532820
		public IQuickHackSkillContent? Content(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IQuickHackSkillContent?(default(IQuickHackSkillContent).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A7D4 RID: 42964
		// (get) Token: 0x06025BDA RID: 154586 RVA: 0x00534680 File Offset: 0x00532880
		public int ContentLength
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

		// Token: 0x06025BDB RID: 154587 RVA: 0x005346AB File Offset: 0x005328AB
		public static Offset<IQuickHackSkill> CreateIQuickHackSkill(FlatBufferBuilder builder, int Id = 0, VectorOffset ContentOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IQuickHackSkill.AddContent(builder, ContentOffset);
			IQuickHackSkill.AddId(builder, Id);
			return IQuickHackSkill.EndIQuickHackSkill(builder);
		}

		// Token: 0x06025BDC RID: 154588 RVA: 0x005346C8 File Offset: 0x005328C8
		public static void StartIQuickHackSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025BDD RID: 154589 RVA: 0x005346D1 File Offset: 0x005328D1
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06025BDE RID: 154590 RVA: 0x005346DC File Offset: 0x005328DC
		public static void AddContent(FlatBufferBuilder builder, VectorOffset contentOffset)
		{
			builder.AddOffset(1, contentOffset.Value, 0);
		}

		// Token: 0x06025BDF RID: 154591 RVA: 0x005346EC File Offset: 0x005328EC
		public static VectorOffset CreateContentVector(FlatBufferBuilder builder, Offset<IQuickHackSkillContent>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025BE0 RID: 154592 RVA: 0x0053472C File Offset: 0x0053292C
		public static VectorOffset CreateContentVectorBlock(FlatBufferBuilder builder, Offset<IQuickHackSkillContent>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IQuickHackSkillContent>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025BE1 RID: 154593 RVA: 0x00534746 File Offset: 0x00532946
		public static VectorOffset CreateContentVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IQuickHackSkillContent>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IQuickHackSkillContent>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025BE2 RID: 154594 RVA: 0x00534764 File Offset: 0x00532964
		public static VectorOffset CreateContentVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IQuickHackSkillContent>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025BE3 RID: 154595 RVA: 0x0053477D File Offset: 0x0053297D
		public static void StartContentVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025BE4 RID: 154596 RVA: 0x00534788 File Offset: 0x00532988
		public static Offset<IQuickHackSkill> EndIQuickHackSkill(FlatBufferBuilder builder)
		{
			return new Offset<IQuickHackSkill>(builder.EndTable());
		}

		// Token: 0x06025BE5 RID: 154597 RVA: 0x00534798 File Offset: 0x00532998
		public IQuickHackSkillT UnPack()
		{
			IQuickHackSkillT quickHackSkillT = new IQuickHackSkillT();
			this.UnPackTo(quickHackSkillT);
			return quickHackSkillT;
		}

		// Token: 0x06025BE6 RID: 154598 RVA: 0x005347B4 File Offset: 0x005329B4
		public void UnPackTo(IQuickHackSkillT _o)
		{
			_o.Id = this.Id;
			_o.Content = new List<IQuickHackSkillContentT>();
			for (int i = 0; i < this.ContentLength; i++)
			{
				_o.Content.Add((this.Content(i) != null) ? this.Content(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06025BE7 RID: 154599 RVA: 0x00534820 File Offset: 0x00532A20
		public static Offset<IQuickHackSkill> Pack(FlatBufferBuilder builder, IQuickHackSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuickHackSkill>);
			}
			VectorOffset contentOffset = default(VectorOffset);
			if (_o.Content != null)
			{
				Offset<IQuickHackSkillContent>[] array = new Offset<IQuickHackSkillContent>[_o.Content.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IQuickHackSkillContent.Pack(builder, _o.Content[i]);
				}
				contentOffset = IQuickHackSkill.CreateContentVector(builder, array);
			}
			return IQuickHackSkill.CreateIQuickHackSkill(builder, _o.Id, contentOffset);
		}

		// Token: 0x0400ECB4 RID: 60596
		private Table __p;
	}
}
