using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200453F RID: 17727
	public class ISaveConfigType_UnionUnion
	{
		// Token: 0x17007B4A RID: 31562
		// (get) Token: 0x06019AB4 RID: 105140 RVA: 0x003A7C69 File Offset: 0x003A5E69
		// (set) Token: 0x06019AB5 RID: 105141 RVA: 0x003A7C71 File Offset: 0x003A5E71
		public ISaveConfigType_Union Type { get; set; }

		// Token: 0x17007B4B RID: 31563
		// (get) Token: 0x06019AB6 RID: 105142 RVA: 0x003A7C7A File Offset: 0x003A5E7A
		// (set) Token: 0x06019AB7 RID: 105143 RVA: 0x003A7C82 File Offset: 0x003A5E82
		public object Value { get; set; }

		// Token: 0x06019AB8 RID: 105144 RVA: 0x003A7C8B File Offset: 0x003A5E8B
		public ISaveConfigType_UnionUnion()
		{
			this.Type = ISaveConfigType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06019AB9 RID: 105145 RVA: 0x003A7CA1 File Offset: 0x003A5EA1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019ABA RID: 105146 RVA: 0x003A7CB3 File Offset: 0x003A5EB3
		public ISaveConfigTypeT AsISaveConfigType()
		{
			return this.As<ISaveConfigTypeT>();
		}

		// Token: 0x06019ABB RID: 105147 RVA: 0x003A7CBB File Offset: 0x003A5EBB
		public static ISaveConfigType_UnionUnion FromISaveConfigType(ISaveConfigTypeT _isaveconfigtype)
		{
			return new ISaveConfigType_UnionUnion
			{
				Type = ISaveConfigType_Union.ISaveConfigType,
				Value = _isaveconfigtype
			};
		}

		// Token: 0x06019ABC RID: 105148 RVA: 0x003A7CD0 File Offset: 0x003A5ED0
		public ISaveNewT AsISaveNew()
		{
			return this.As<ISaveNewT>();
		}

		// Token: 0x06019ABD RID: 105149 RVA: 0x003A7CD8 File Offset: 0x003A5ED8
		public static ISaveConfigType_UnionUnion FromISaveNew(ISaveNewT _isavenew)
		{
			return new ISaveConfigType_UnionUnion
			{
				Type = ISaveConfigType_Union.ISaveNew,
				Value = _isavenew
			};
		}

		// Token: 0x06019ABE RID: 105150 RVA: 0x003A7CED File Offset: 0x003A5EED
		public ISavePointT AsISavePoint()
		{
			return this.As<ISavePointT>();
		}

		// Token: 0x06019ABF RID: 105151 RVA: 0x003A7CF5 File Offset: 0x003A5EF5
		public static ISaveConfigType_UnionUnion FromISavePoint(ISavePointT _isavepoint)
		{
			return new ISaveConfigType_UnionUnion
			{
				Type = ISaveConfigType_Union.ISavePoint,
				Value = _isavepoint
			};
		}

		// Token: 0x06019AC0 RID: 105152 RVA: 0x003A7D0C File Offset: 0x003A5F0C
		public static int Pack(FlatBufferBuilder builder, ISaveConfigType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISaveConfigType_Union.ISaveConfigType:
				return ISaveConfigType.Pack(builder, _o.AsISaveConfigType()).Value;
			case ISaveConfigType_Union.ISaveNew:
				return ISaveNew.Pack(builder, _o.AsISaveNew()).Value;
			case ISaveConfigType_Union.ISavePoint:
				return ISavePoint.Pack(builder, _o.AsISavePoint()).Value;
			default:
				return 0;
			}
		}
	}
}
