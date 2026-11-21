using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DD6 RID: 24022
	public struct IQuickHackSkill : IFlatbufferObject
	{
		// Token: 0x1700B0F6 RID: 45302
		// (get) Token: 0x060280F2 RID: 164082 RVA: 0x0057A702 File Offset: 0x00578902
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060280F3 RID: 164083 RVA: 0x0057A70F File Offset: 0x0057890F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060280F4 RID: 164084 RVA: 0x0057A718 File Offset: 0x00578918
		public static IQuickHackSkill GetRootAsIQuickHackSkill(ByteBuffer _bb)
		{
			return IQuickHackSkill.GetRootAsIQuickHackSkill(_bb, default(IQuickHackSkill));
		}

		// Token: 0x060280F5 RID: 164085 RVA: 0x0057A734 File Offset: 0x00578934
		public static IQuickHackSkill GetRootAsIQuickHackSkill(ByteBuffer _bb, IQuickHackSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060280F6 RID: 164086 RVA: 0x0057A751 File Offset: 0x00578951
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060280F7 RID: 164087 RVA: 0x0057A760 File Offset: 0x00578960
		public IQuickHackSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B0F7 RID: 45303
		// (get) Token: 0x060280F8 RID: 164088 RVA: 0x0057A770 File Offset: 0x00578970
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

		// Token: 0x060280F9 RID: 164089 RVA: 0x0057A7AC File Offset: 0x005789AC
		public IQuickHackSkillContent? Content(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IQuickHackSkillContent?(default(IQuickHackSkillContent).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B0F8 RID: 45304
		// (get) Token: 0x060280FA RID: 164090 RVA: 0x0057A80C File Offset: 0x00578A0C
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

		// Token: 0x060280FB RID: 164091 RVA: 0x0057A837 File Offset: 0x00578A37
		public static Offset<IQuickHackSkill> CreateIQuickHackSkill(FlatBufferBuilder builder, int Id = 0, VectorOffset ContentOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IQuickHackSkill.AddContent(builder, ContentOffset);
			IQuickHackSkill.AddId(builder, Id);
			return IQuickHackSkill.EndIQuickHackSkill(builder);
		}

		// Token: 0x060280FC RID: 164092 RVA: 0x0057A854 File Offset: 0x00578A54
		public static void StartIQuickHackSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060280FD RID: 164093 RVA: 0x0057A85D File Offset: 0x00578A5D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x060280FE RID: 164094 RVA: 0x0057A868 File Offset: 0x00578A68
		public static void AddContent(FlatBufferBuilder builder, VectorOffset contentOffset)
		{
			builder.AddOffset(1, contentOffset.Value, 0);
		}

		// Token: 0x060280FF RID: 164095 RVA: 0x0057A878 File Offset: 0x00578A78
		public static VectorOffset CreateContentVector(FlatBufferBuilder builder, Offset<IQuickHackSkillContent>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028100 RID: 164096 RVA: 0x0057A8B8 File Offset: 0x00578AB8
		public static VectorOffset CreateContentVectorBlock(FlatBufferBuilder builder, Offset<IQuickHackSkillContent>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IQuickHackSkillContent>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028101 RID: 164097 RVA: 0x0057A8D2 File Offset: 0x00578AD2
		public static VectorOffset CreateContentVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IQuickHackSkillContent>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IQuickHackSkillContent>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028102 RID: 164098 RVA: 0x0057A8F0 File Offset: 0x00578AF0
		public static VectorOffset CreateContentVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IQuickHackSkillContent>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028103 RID: 164099 RVA: 0x0057A909 File Offset: 0x00578B09
		public static void StartContentVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028104 RID: 164100 RVA: 0x0057A914 File Offset: 0x00578B14
		public static Offset<IQuickHackSkill> EndIQuickHackSkill(FlatBufferBuilder builder)
		{
			return new Offset<IQuickHackSkill>(builder.EndTable());
		}

		// Token: 0x06028105 RID: 164101 RVA: 0x0057A924 File Offset: 0x00578B24
		public IQuickHackSkillT UnPack()
		{
			IQuickHackSkillT quickHackSkillT = new IQuickHackSkillT();
			this.UnPackTo(quickHackSkillT);
			return quickHackSkillT;
		}

		// Token: 0x06028106 RID: 164102 RVA: 0x0057A940 File Offset: 0x00578B40
		public void UnPackTo(IQuickHackSkillT _o)
		{
			_o.Id = this.Id;
			_o.Content = new List<IQuickHackSkillContentT>();
			for (int i = 0; i < this.ContentLength; i++)
			{
				_o.Content.Add((this.Content(i) != null) ? this.Content(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06028107 RID: 164103 RVA: 0x0057A9AC File Offset: 0x00578BAC
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

		// Token: 0x0400F99F RID: 63903
		private Table __p;
	}
}
