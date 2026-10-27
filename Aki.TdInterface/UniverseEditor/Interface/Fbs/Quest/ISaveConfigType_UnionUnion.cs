using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040FE RID: 16638
	public class ISaveConfigType_UnionUnion
	{
		// Token: 0x17007544 RID: 30020
		// (get) Token: 0x06018413 RID: 99347 RVA: 0x0037DD19 File Offset: 0x0037BF19
		// (set) Token: 0x06018414 RID: 99348 RVA: 0x0037DD21 File Offset: 0x0037BF21
		public ISaveConfigType_Union Type { get; set; }

		// Token: 0x17007545 RID: 30021
		// (get) Token: 0x06018415 RID: 99349 RVA: 0x0037DD2A File Offset: 0x0037BF2A
		// (set) Token: 0x06018416 RID: 99350 RVA: 0x0037DD32 File Offset: 0x0037BF32
		public object Value { get; set; }

		// Token: 0x06018417 RID: 99351 RVA: 0x0037DD3B File Offset: 0x0037BF3B
		public ISaveConfigType_UnionUnion()
		{
			this.Type = ISaveConfigType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06018418 RID: 99352 RVA: 0x0037DD51 File Offset: 0x0037BF51
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06018419 RID: 99353 RVA: 0x0037DD63 File Offset: 0x0037BF63
		public ISaveConfigTypeT AsISaveConfigType()
		{
			return this.As<ISaveConfigTypeT>();
		}

		// Token: 0x0601841A RID: 99354 RVA: 0x0037DD6B File Offset: 0x0037BF6B
		public static ISaveConfigType_UnionUnion FromISaveConfigType(ISaveConfigTypeT _isaveconfigtype)
		{
			return new ISaveConfigType_UnionUnion
			{
				Type = ISaveConfigType_Union.ISaveConfigType,
				Value = _isaveconfigtype
			};
		}

		// Token: 0x0601841B RID: 99355 RVA: 0x0037DD80 File Offset: 0x0037BF80
		public ISaveNewT AsISaveNew()
		{
			return this.As<ISaveNewT>();
		}

		// Token: 0x0601841C RID: 99356 RVA: 0x0037DD88 File Offset: 0x0037BF88
		public static ISaveConfigType_UnionUnion FromISaveNew(ISaveNewT _isavenew)
		{
			return new ISaveConfigType_UnionUnion
			{
				Type = ISaveConfigType_Union.ISaveNew,
				Value = _isavenew
			};
		}

		// Token: 0x0601841D RID: 99357 RVA: 0x0037DD9D File Offset: 0x0037BF9D
		public ISavePointT AsISavePoint()
		{
			return this.As<ISavePointT>();
		}

		// Token: 0x0601841E RID: 99358 RVA: 0x0037DDA5 File Offset: 0x0037BFA5
		public static ISaveConfigType_UnionUnion FromISavePoint(ISavePointT _isavepoint)
		{
			return new ISaveConfigType_UnionUnion
			{
				Type = ISaveConfigType_Union.ISavePoint,
				Value = _isavepoint
			};
		}

		// Token: 0x0601841F RID: 99359 RVA: 0x0037DDBC File Offset: 0x0037BFBC
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
