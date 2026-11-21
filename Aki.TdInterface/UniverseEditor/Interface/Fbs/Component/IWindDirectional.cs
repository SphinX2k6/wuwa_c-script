using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006190 RID: 24976
	public struct IWindDirectional : IFlatbufferObject
	{
		// Token: 0x1700BA43 RID: 47683
		// (get) Token: 0x0602A71F RID: 173855 RVA: 0x005CA4E8 File Offset: 0x005C86E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A720 RID: 173856 RVA: 0x005CA4F5 File Offset: 0x005C86F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A721 RID: 173857 RVA: 0x005CA4FC File Offset: 0x005C86FC
		public static IWindDirectional GetRootAsIWindDirectional(ByteBuffer _bb)
		{
			return IWindDirectional.GetRootAsIWindDirectional(_bb, default(IWindDirectional));
		}

		// Token: 0x0602A722 RID: 173858 RVA: 0x005CA518 File Offset: 0x005C8718
		public static IWindDirectional GetRootAsIWindDirectional(ByteBuffer _bb, IWindDirectional obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A723 RID: 173859 RVA: 0x005CA535 File Offset: 0x005C8735
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A724 RID: 173860 RVA: 0x005CA544 File Offset: 0x005C8744
		public IWindDirectional __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA44 RID: 47684
		// (get) Token: 0x0602A725 RID: 173861 RVA: 0x005CA554 File Offset: 0x005C8754
		public EWindSourceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWindSourceType.Directional;
				}
				return (EWindSourceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BA45 RID: 47685
		// (get) Token: 0x0602A726 RID: 173862 RVA: 0x005CA590 File Offset: 0x005C8790
		public IVectorInfo? Rot
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602A727 RID: 173863 RVA: 0x005CA5F0 File Offset: 0x005C87F0
		public IWindDirectionalStateGrade? Grades(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IWindDirectionalStateGrade?(default(IWindDirectionalStateGrade).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BA46 RID: 47686
		// (get) Token: 0x0602A728 RID: 173864 RVA: 0x005CA650 File Offset: 0x005C8850
		public int GradesLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602A729 RID: 173865 RVA: 0x005CA67B File Offset: 0x005C887B
		public static Offset<IWindDirectional> CreateIWindDirectional(FlatBufferBuilder builder, EWindSourceType Type = EWindSourceType.Directional, Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>), VectorOffset GradesOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IWindDirectional.AddGrades(builder, GradesOffset);
			IWindDirectional.AddRot(builder, RotOffset);
			IWindDirectional.AddType(builder, Type);
			return IWindDirectional.EndIWindDirectional(builder);
		}

		// Token: 0x0602A72A RID: 173866 RVA: 0x005CA69F File Offset: 0x005C889F
		public static void StartIWindDirectional(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A72B RID: 173867 RVA: 0x005CA6A8 File Offset: 0x005C88A8
		public static void AddType(FlatBufferBuilder builder, EWindSourceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A72C RID: 173868 RVA: 0x005CA6B3 File Offset: 0x005C88B3
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(1, rotOffset.Value, 0);
		}

		// Token: 0x0602A72D RID: 173869 RVA: 0x005CA6C3 File Offset: 0x005C88C3
		public static void AddGrades(FlatBufferBuilder builder, VectorOffset gradesOffset)
		{
			builder.AddOffset(2, gradesOffset.Value, 0);
		}

		// Token: 0x0602A72E RID: 173870 RVA: 0x005CA6D4 File Offset: 0x005C88D4
		public static VectorOffset CreateGradesVector(FlatBufferBuilder builder, Offset<IWindDirectionalStateGrade>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A72F RID: 173871 RVA: 0x005CA714 File Offset: 0x005C8914
		public static VectorOffset CreateGradesVectorBlock(FlatBufferBuilder builder, Offset<IWindDirectionalStateGrade>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IWindDirectionalStateGrade>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A730 RID: 173872 RVA: 0x005CA72E File Offset: 0x005C892E
		public static VectorOffset CreateGradesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IWindDirectionalStateGrade>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IWindDirectionalStateGrade>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A731 RID: 173873 RVA: 0x005CA74C File Offset: 0x005C894C
		public static VectorOffset CreateGradesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IWindDirectionalStateGrade>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A732 RID: 173874 RVA: 0x005CA765 File Offset: 0x005C8965
		public static void StartGradesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A733 RID: 173875 RVA: 0x005CA770 File Offset: 0x005C8970
		public static Offset<IWindDirectional> EndIWindDirectional(FlatBufferBuilder builder)
		{
			return new Offset<IWindDirectional>(builder.EndTable());
		}

		// Token: 0x0602A734 RID: 173876 RVA: 0x005CA780 File Offset: 0x005C8980
		public IWindDirectionalT UnPack()
		{
			IWindDirectionalT windDirectionalT = new IWindDirectionalT();
			this.UnPackTo(windDirectionalT);
			return windDirectionalT;
		}

		// Token: 0x0602A735 RID: 173877 RVA: 0x005CA79C File Offset: 0x005C899C
		public void UnPackTo(IWindDirectionalT _o)
		{
			_o.Type = this.Type;
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
			_o.Grades = new List<IWindDirectionalStateGradeT>();
			for (int i = 0; i < this.GradesLength; i++)
			{
				_o.Grades.Add((this.Grades(i) != null) ? this.Grades(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602A736 RID: 173878 RVA: 0x005CA838 File Offset: 0x005C8A38
		public static Offset<IWindDirectional> Pack(FlatBufferBuilder builder, IWindDirectionalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWindDirectional>);
			}
			Offset<IVectorInfo> rotOffset = (_o.Rot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rot);
			VectorOffset gradesOffset = default(VectorOffset);
			if (_o.Grades != null)
			{
				Offset<IWindDirectionalStateGrade>[] array = new Offset<IWindDirectionalStateGrade>[_o.Grades.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IWindDirectionalStateGrade.Pack(builder, _o.Grades[i]);
				}
				gradesOffset = IWindDirectional.CreateGradesVector(builder, array);
			}
			return IWindDirectional.CreateIWindDirectional(builder, _o.Type, rotOffset, gradesOffset);
		}

		// Token: 0x0400FFD9 RID: 65497
		private Table __p;
	}
}
