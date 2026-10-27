using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C1A RID: 3098
	public struct EdgeRunnerLordGym : IFlatbufferObject
	{
		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06006700 RID: 26368 RVA: 0x0021ED11 File Offset: 0x0021CF11
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006701 RID: 26369 RVA: 0x0021ED1E File Offset: 0x0021CF1E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006702 RID: 26370 RVA: 0x0021ED28 File Offset: 0x0021CF28
		public static EdgeRunnerLordGym GetRootAsEdgeRunnerLordGym(ByteBuffer _bb)
		{
			return EdgeRunnerLordGym.GetRootAsEdgeRunnerLordGym(_bb, default(EdgeRunnerLordGym));
		}

		// Token: 0x06006703 RID: 26371 RVA: 0x0021ED44 File Offset: 0x0021CF44
		public static EdgeRunnerLordGym GetRootAsEdgeRunnerLordGym(ByteBuffer _bb, EdgeRunnerLordGym obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006704 RID: 26372 RVA: 0x0021ED61 File Offset: 0x0021CF61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006705 RID: 26373 RVA: 0x0021ED70 File Offset: 0x0021CF70
		public EdgeRunnerLordGym __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06006706 RID: 26374 RVA: 0x0021ED80 File Offset: 0x0021CF80
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

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06006707 RID: 26375 RVA: 0x0021EDBC File Offset: 0x0021CFBC
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

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06006708 RID: 26376 RVA: 0x0021EDF8 File Offset: 0x0021CFF8
		public int IsHard
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

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x06006709 RID: 26377 RVA: 0x0021EE34 File Offset: 0x0021D034
		public int InstId
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

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x0600670A RID: 26378 RVA: 0x0021EE74 File Offset: 0x0021D074
		public int PlayId
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

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x0600670B RID: 26379 RVA: 0x0021EEB4 File Offset: 0x0021D0B4
		public int RewardId
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

		// Token: 0x0600670C RID: 26380 RVA: 0x0021EEF4 File Offset: 0x0021D0F4
		public int TrialRole(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x0600670D RID: 26381 RVA: 0x0021EF34 File Offset: 0x0021D134
		public int TrialRoleLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600670E RID: 26382 RVA: 0x0021EF60 File Offset: 0x0021D160
		public Span<int> GetTrialRoleBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600670F RID: 26383 RVA: 0x0021EF70 File Offset: 0x0021D170
		public int[] GetTrialRoleArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06006710 RID: 26384 RVA: 0x0021EF88 File Offset: 0x0021D188
		public int UpRole(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06006711 RID: 26385 RVA: 0x0021EFC8 File Offset: 0x0021D1C8
		public int UpRoleLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006712 RID: 26386 RVA: 0x0021EFF4 File Offset: 0x0021D1F4
		public Span<int> GetUpRoleBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06006713 RID: 26387 RVA: 0x0021F004 File Offset: 0x0021D204
		public int[] GetUpRoleArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06006714 RID: 26388 RVA: 0x0021F01C File Offset: 0x0021D21C
		public string LevelTitle
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006715 RID: 26389 RVA: 0x0021F054 File Offset: 0x0021D254
		public Span<byte> GetLevelTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06006716 RID: 26390 RVA: 0x0021F064 File Offset: 0x0021D264
		public byte[] GetLevelTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06006717 RID: 26391 RVA: 0x0021F07C File Offset: 0x0021D27C
		public string Title
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006718 RID: 26392 RVA: 0x0021F0B4 File Offset: 0x0021D2B4
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06006719 RID: 26393 RVA: 0x0021F0C4 File Offset: 0x0021D2C4
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x0600671A RID: 26394 RVA: 0x0021F0DC File Offset: 0x0021D2DC
		public string BuffDesc
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600671B RID: 26395 RVA: 0x0021F114 File Offset: 0x0021D314
		public Span<byte> GetBuffDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600671C RID: 26396 RVA: 0x0021F124 File Offset: 0x0021D324
		public byte[] GetBuffDescArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0600671D RID: 26397 RVA: 0x0021F13C File Offset: 0x0021D33C
		public string BuffNum(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x0600671E RID: 26398 RVA: 0x0021F178 File Offset: 0x0021D378
		public int BuffNumLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x0600671F RID: 26399 RVA: 0x0021F1A4 File Offset: 0x0021D3A4
		public int Level
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06006720 RID: 26400 RVA: 0x0021F1E4 File Offset: 0x0021D3E4
		public int MeshId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006721 RID: 26401 RVA: 0x0021F224 File Offset: 0x0021D424
		public float Zoom(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06006722 RID: 26402 RVA: 0x0021F268 File Offset: 0x0021D468
		public int ZoomLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006723 RID: 26403 RVA: 0x0021F294 File Offset: 0x0021D494
		public Span<float> GetZoomBytes()
		{
			return this.__p.__vector_as_span<float>(32, 4);
		}

		// Token: 0x06006724 RID: 26404 RVA: 0x0021F2A4 File Offset: 0x0021D4A4
		public float[] GetZoomArray()
		{
			return this.__p.__vector_as_array<float>(32) ?? Array.Empty<float>();
		}

		// Token: 0x06006725 RID: 26405 RVA: 0x0021F2BC File Offset: 0x0021D4BC
		public float Location(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06006726 RID: 26406 RVA: 0x0021F300 File Offset: 0x0021D500
		public int LocationLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006727 RID: 26407 RVA: 0x0021F32C File Offset: 0x0021D52C
		public Span<float> GetLocationBytes()
		{
			return this.__p.__vector_as_span<float>(34, 4);
		}

		// Token: 0x06006728 RID: 26408 RVA: 0x0021F33C File Offset: 0x0021D53C
		public float[] GetLocationArray()
		{
			return this.__p.__vector_as_array<float>(34) ?? Array.Empty<float>();
		}

		// Token: 0x06006729 RID: 26409 RVA: 0x0021F354 File Offset: 0x0021D554
		public float Rotator(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x0600672A RID: 26410 RVA: 0x0021F398 File Offset: 0x0021D598
		public int RotatorLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600672B RID: 26411 RVA: 0x0021F3C4 File Offset: 0x0021D5C4
		public Span<float> GetRotatorBytes()
		{
			return this.__p.__vector_as_span<float>(36, 4);
		}

		// Token: 0x0600672C RID: 26412 RVA: 0x0021F3D4 File Offset: 0x0021D5D4
		public float[] GetRotatorArray()
		{
			return this.__p.__vector_as_array<float>(36) ?? Array.Empty<float>();
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x0600672D RID: 26413 RVA: 0x0021F3EC File Offset: 0x0021D5EC
		public string LordUISceneEffect
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600672E RID: 26414 RVA: 0x0021F424 File Offset: 0x0021D624
		public Span<byte> GetLordUISceneEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600672F RID: 26415 RVA: 0x0021F434 File Offset: 0x0021D634
		public byte[] GetLordUISceneEffectArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06006730 RID: 26416 RVA: 0x0021F44C File Offset: 0x0021D64C
		public string MaterialController
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006731 RID: 26417 RVA: 0x0021F484 File Offset: 0x0021D684
		public Span<byte> GetMaterialControllerBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06006732 RID: 26418 RVA: 0x0021F494 File Offset: 0x0021D694
		public byte[] GetMaterialControllerArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06006733 RID: 26419 RVA: 0x0021F4AC File Offset: 0x0021D6AC
		public string StandAnim
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006734 RID: 26420 RVA: 0x0021F4E4 File Offset: 0x0021D6E4
		public Span<byte> GetStandAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06006735 RID: 26421 RVA: 0x0021F4F4 File Offset: 0x0021D6F4
		public byte[] GetStandAnimArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x06006736 RID: 26422 RVA: 0x0021F50C File Offset: 0x0021D70C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffNumIter()或GetBuffNumBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BuffNum()
		{
			return this.BuffNumIter().ToArray<string>();
		}

		// Token: 0x06006737 RID: 26423 RVA: 0x0021F519 File Offset: 0x0021D719
		[NullableContext(1)]
		public readonly IEnumerable<string> BuffNumIter()
		{
			EdgeRunnerLordGym.<BuffNumIter>d__77 <BuffNumIter>d__ = new EdgeRunnerLordGym.<BuffNumIter>d__77(-2);
			<BuffNumIter>d__.<>3__<>4__this = this;
			return <BuffNumIter>d__;
		}

		// Token: 0x06006738 RID: 26424 RVA: 0x0021F530 File Offset: 0x0021D730
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LocationIter()或GetLocationBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Location()
		{
			EdgeRunnerLordGym edgeRunnerLordGym = this;
			return edgeRunnerLordGym.GetLocationArray() ?? Array.Empty<float>();
		}

		// Token: 0x06006739 RID: 26425 RVA: 0x0021F554 File Offset: 0x0021D754
		[NullableContext(1)]
		public readonly IEnumerable<float> LocationIter()
		{
			EdgeRunnerLordGym.<LocationIter>d__79 <LocationIter>d__ = new EdgeRunnerLordGym.<LocationIter>d__79(-2);
			<LocationIter>d__.<>3__<>4__this = this;
			return <LocationIter>d__;
		}

		// Token: 0x0600673A RID: 26426 RVA: 0x0021F56C File Offset: 0x0021D76C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RotatorIter()或GetRotatorBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Rotator()
		{
			EdgeRunnerLordGym edgeRunnerLordGym = this;
			return edgeRunnerLordGym.GetRotatorArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600673B RID: 26427 RVA: 0x0021F590 File Offset: 0x0021D790
		[NullableContext(1)]
		public readonly IEnumerable<float> RotatorIter()
		{
			EdgeRunnerLordGym.<RotatorIter>d__81 <RotatorIter>d__ = new EdgeRunnerLordGym.<RotatorIter>d__81(-2);
			<RotatorIter>d__.<>3__<>4__this = this;
			return <RotatorIter>d__;
		}

		// Token: 0x0600673C RID: 26428 RVA: 0x0021F5A8 File Offset: 0x0021D7A8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TrialRoleIter()或GetTrialRoleBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TrialRole()
		{
			EdgeRunnerLordGym edgeRunnerLordGym = this;
			return edgeRunnerLordGym.GetTrialRoleArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600673D RID: 26429 RVA: 0x0021F5CC File Offset: 0x0021D7CC
		[NullableContext(1)]
		public readonly IEnumerable<int> TrialRoleIter()
		{
			EdgeRunnerLordGym.<TrialRoleIter>d__83 <TrialRoleIter>d__ = new EdgeRunnerLordGym.<TrialRoleIter>d__83(-2);
			<TrialRoleIter>d__.<>3__<>4__this = this;
			return <TrialRoleIter>d__;
		}

		// Token: 0x0600673E RID: 26430 RVA: 0x0021F5E4 File Offset: 0x0021D7E4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UpRoleIter()或GetUpRoleBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] UpRole()
		{
			EdgeRunnerLordGym edgeRunnerLordGym = this;
			return edgeRunnerLordGym.GetUpRoleArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600673F RID: 26431 RVA: 0x0021F608 File Offset: 0x0021D808
		[NullableContext(1)]
		public readonly IEnumerable<int> UpRoleIter()
		{
			EdgeRunnerLordGym.<UpRoleIter>d__85 <UpRoleIter>d__ = new EdgeRunnerLordGym.<UpRoleIter>d__85(-2);
			<UpRoleIter>d__.<>3__<>4__this = this;
			return <UpRoleIter>d__;
		}

		// Token: 0x06006740 RID: 26432 RVA: 0x0021F620 File Offset: 0x0021D820
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ZoomIter()或GetZoomBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] Zoom()
		{
			EdgeRunnerLordGym edgeRunnerLordGym = this;
			return edgeRunnerLordGym.GetZoomArray() ?? Array.Empty<float>();
		}

		// Token: 0x06006741 RID: 26433 RVA: 0x0021F644 File Offset: 0x0021D844
		[NullableContext(1)]
		public readonly IEnumerable<float> ZoomIter()
		{
			EdgeRunnerLordGym.<ZoomIter>d__87 <ZoomIter>d__ = new EdgeRunnerLordGym.<ZoomIter>d__87(-2);
			<ZoomIter>d__.<>3__<>4__this = this;
			return <ZoomIter>d__;
		}

		// Token: 0x04004C5A RID: 19546
		private Table __p;
	}
}
