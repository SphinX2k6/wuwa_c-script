using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B7A RID: 23418
	public struct IWindDirectional : IFlatbufferObject
	{
		// Token: 0x1700B0FB RID: 45307
		// (get) Token: 0x0602815B RID: 164187 RVA: 0x00582A58 File Offset: 0x00580C58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602815C RID: 164188 RVA: 0x00582A65 File Offset: 0x00580C65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602815D RID: 164189 RVA: 0x00582A6C File Offset: 0x00580C6C
		public static IWindDirectional GetRootAsIWindDirectional(ByteBuffer _bb)
		{
			return IWindDirectional.GetRootAsIWindDirectional(_bb, default(IWindDirectional));
		}

		// Token: 0x0602815E RID: 164190 RVA: 0x00582A88 File Offset: 0x00580C88
		public static IWindDirectional GetRootAsIWindDirectional(ByteBuffer _bb, IWindDirectional obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602815F RID: 164191 RVA: 0x00582AA5 File Offset: 0x00580CA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028160 RID: 164192 RVA: 0x00582AB4 File Offset: 0x00580CB4
		public IWindDirectional __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B0FC RID: 45308
		// (get) Token: 0x06028161 RID: 164193 RVA: 0x00582AC4 File Offset: 0x00580CC4
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

		// Token: 0x1700B0FD RID: 45309
		// (get) Token: 0x06028162 RID: 164194 RVA: 0x00582B00 File Offset: 0x00580D00
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

		// Token: 0x06028163 RID: 164195 RVA: 0x00582B60 File Offset: 0x00580D60
		public IWindDirectionalStateGrade? Grades(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IWindDirectionalStateGrade?(default(IWindDirectionalStateGrade).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B0FE RID: 45310
		// (get) Token: 0x06028164 RID: 164196 RVA: 0x00582BC0 File Offset: 0x00580DC0
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

		// Token: 0x06028165 RID: 164197 RVA: 0x00582BEB File Offset: 0x00580DEB
		public static Offset<IWindDirectional> CreateIWindDirectional(FlatBufferBuilder builder, EWindSourceType Type = EWindSourceType.Directional, Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>), VectorOffset GradesOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IWindDirectional.AddGrades(builder, GradesOffset);
			IWindDirectional.AddRot(builder, RotOffset);
			IWindDirectional.AddType(builder, Type);
			return IWindDirectional.EndIWindDirectional(builder);
		}

		// Token: 0x06028166 RID: 164198 RVA: 0x00582C0F File Offset: 0x00580E0F
		public static void StartIWindDirectional(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028167 RID: 164199 RVA: 0x00582C18 File Offset: 0x00580E18
		public static void AddType(FlatBufferBuilder builder, EWindSourceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028168 RID: 164200 RVA: 0x00582C23 File Offset: 0x00580E23
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(1, rotOffset.Value, 0);
		}

		// Token: 0x06028169 RID: 164201 RVA: 0x00582C33 File Offset: 0x00580E33
		public static void AddGrades(FlatBufferBuilder builder, VectorOffset gradesOffset)
		{
			builder.AddOffset(2, gradesOffset.Value, 0);
		}

		// Token: 0x0602816A RID: 164202 RVA: 0x00582C44 File Offset: 0x00580E44
		public static VectorOffset CreateGradesVector(FlatBufferBuilder builder, Offset<IWindDirectionalStateGrade>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602816B RID: 164203 RVA: 0x00582C84 File Offset: 0x00580E84
		public static VectorOffset CreateGradesVectorBlock(FlatBufferBuilder builder, Offset<IWindDirectionalStateGrade>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IWindDirectionalStateGrade>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602816C RID: 164204 RVA: 0x00582C9E File Offset: 0x00580E9E
		public static VectorOffset CreateGradesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IWindDirectionalStateGrade>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IWindDirectionalStateGrade>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602816D RID: 164205 RVA: 0x00582CBC File Offset: 0x00580EBC
		public static VectorOffset CreateGradesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IWindDirectionalStateGrade>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602816E RID: 164206 RVA: 0x00582CD5 File Offset: 0x00580ED5
		public static void StartGradesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602816F RID: 164207 RVA: 0x00582CE0 File Offset: 0x00580EE0
		public static Offset<IWindDirectional> EndIWindDirectional(FlatBufferBuilder builder)
		{
			return new Offset<IWindDirectional>(builder.EndTable());
		}

		// Token: 0x06028170 RID: 164208 RVA: 0x00582CF0 File Offset: 0x00580EF0
		public IWindDirectionalT UnPack()
		{
			IWindDirectionalT windDirectionalT = new IWindDirectionalT();
			this.UnPackTo(windDirectionalT);
			return windDirectionalT;
		}

		// Token: 0x06028171 RID: 164209 RVA: 0x00582D0C File Offset: 0x00580F0C
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

		// Token: 0x06028172 RID: 164210 RVA: 0x00582DA8 File Offset: 0x00580FA8
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

		// Token: 0x0400F2D3 RID: 62163
		private Table __p;
	}
}
