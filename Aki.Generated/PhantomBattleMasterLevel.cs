using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FBB RID: 4027
	public struct PhantomBattleMasterLevel : IFlatbufferObject
	{
		// Token: 0x170026CA RID: 9930
		// (get) Token: 0x0600ADA5 RID: 44453 RVA: 0x002CDD5A File Offset: 0x002CBF5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ADA6 RID: 44454 RVA: 0x002CDD67 File Offset: 0x002CBF67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ADA7 RID: 44455 RVA: 0x002CDD70 File Offset: 0x002CBF70
		public static PhantomBattleMasterLevel GetRootAsPhantomBattleMasterLevel(ByteBuffer _bb)
		{
			return PhantomBattleMasterLevel.GetRootAsPhantomBattleMasterLevel(_bb, default(PhantomBattleMasterLevel));
		}

		// Token: 0x0600ADA8 RID: 44456 RVA: 0x002CDD8C File Offset: 0x002CBF8C
		public static PhantomBattleMasterLevel GetRootAsPhantomBattleMasterLevel(ByteBuffer _bb, PhantomBattleMasterLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ADA9 RID: 44457 RVA: 0x002CDDA9 File Offset: 0x002CBFA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ADAA RID: 44458 RVA: 0x002CDDB8 File Offset: 0x002CBFB8
		public PhantomBattleMasterLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026CB RID: 9931
		// (get) Token: 0x0600ADAB RID: 44459 RVA: 0x002CDDC8 File Offset: 0x002CBFC8
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

		// Token: 0x170026CC RID: 9932
		// (get) Token: 0x0600ADAC RID: 44460 RVA: 0x002CDE04 File Offset: 0x002CC004
		public int Level
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

		// Token: 0x170026CD RID: 9933
		// (get) Token: 0x0600ADAD RID: 44461 RVA: 0x002CDE40 File Offset: 0x002CC040
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170026CE RID: 9934
		// (get) Token: 0x0600ADAE RID: 44462 RVA: 0x002CDE7C File Offset: 0x002CC07C
		public int Exp
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170026CF RID: 9935
		// (get) Token: 0x0600ADAF RID: 44463 RVA: 0x002CDEBC File Offset: 0x002CC0BC
		public int ExpNext
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170026D0 RID: 9936
		// (get) Token: 0x0600ADB0 RID: 44464 RVA: 0x002CDEFC File Offset: 0x002CC0FC
		public int ExpNeed
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170026D1 RID: 9937
		// (get) Token: 0x0600ADB1 RID: 44465 RVA: 0x002CDF3C File Offset: 0x002CC13C
		public int UnlockDropId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170026D2 RID: 9938
		// (get) Token: 0x0600ADB2 RID: 44466 RVA: 0x002CDF7C File Offset: 0x002CC17C
		public int NormalDropId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170026D3 RID: 9939
		// (get) Token: 0x0600ADB3 RID: 44467 RVA: 0x002CDFBC File Offset: 0x002CC1BC
		public int TitleId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ADB4 RID: 44468 RVA: 0x002CDFFC File Offset: 0x002CC1FC
		public string Desc(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170026D4 RID: 9940
		// (get) Token: 0x0600ADB5 RID: 44469 RVA: 0x002CE038 File Offset: 0x002CC238
		public int DescLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600ADB6 RID: 44470 RVA: 0x002CE064 File Offset: 0x002CC264
		[NullableContext(1)]
		public string[] Desc()
		{
			return this.DescIter().ToArray<string>();
		}

		// Token: 0x0600ADB7 RID: 44471 RVA: 0x002CE071 File Offset: 0x002CC271
		[NullableContext(1)]
		public IEnumerable<string> DescIter()
		{
			PhantomBattleMasterLevel.<DescIter>d__30 <DescIter>d__ = new PhantomBattleMasterLevel.<DescIter>d__30(-2);
			<DescIter>d__.<>3__<>4__this = this;
			return <DescIter>d__;
		}

		// Token: 0x04005579 RID: 21881
		private Table __p;
	}
}
