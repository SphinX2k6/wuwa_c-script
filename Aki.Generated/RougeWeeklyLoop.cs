using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200116B RID: 4459
	public struct RougeWeeklyLoop : IFlatbufferObject
	{
		// Token: 0x170034F1 RID: 13553
		// (get) Token: 0x0600D470 RID: 54384 RVA: 0x00322CC7 File Offset: 0x00320EC7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D471 RID: 54385 RVA: 0x00322CD4 File Offset: 0x00320ED4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D472 RID: 54386 RVA: 0x00322CDC File Offset: 0x00320EDC
		public static RougeWeeklyLoop GetRootAsRougeWeeklyLoop(ByteBuffer _bb)
		{
			return RougeWeeklyLoop.GetRootAsRougeWeeklyLoop(_bb, default(RougeWeeklyLoop));
		}

		// Token: 0x0600D473 RID: 54387 RVA: 0x00322CF8 File Offset: 0x00320EF8
		public static RougeWeeklyLoop GetRootAsRougeWeeklyLoop(ByteBuffer _bb, RougeWeeklyLoop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D474 RID: 54388 RVA: 0x00322D15 File Offset: 0x00320F15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D475 RID: 54389 RVA: 0x00322D24 File Offset: 0x00320F24
		public RougeWeeklyLoop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034F2 RID: 13554
		// (get) Token: 0x0600D476 RID: 54390 RVA: 0x00322D34 File Offset: 0x00320F34
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

		// Token: 0x170034F3 RID: 13555
		// (get) Token: 0x0600D477 RID: 54391 RVA: 0x00322D70 File Offset: 0x00320F70
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005774 RID: 22388
		private Table __p;
	}
}
