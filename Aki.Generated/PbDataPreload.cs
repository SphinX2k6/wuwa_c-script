using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EB5 RID: 3765
	public struct PbDataPreload : IFlatbufferObject
	{
		// Token: 0x170024D0 RID: 9424
		// (get) Token: 0x0600A347 RID: 41799 RVA: 0x002A7024 File Offset: 0x002A5224
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A348 RID: 41800 RVA: 0x002A7031 File Offset: 0x002A5231
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A349 RID: 41801 RVA: 0x002A7038 File Offset: 0x002A5238
		public static PbDataPreload GetRootAsPbDataPreload(ByteBuffer _bb)
		{
			return PbDataPreload.GetRootAsPbDataPreload(_bb, default(PbDataPreload));
		}

		// Token: 0x0600A34A RID: 41802 RVA: 0x002A7054 File Offset: 0x002A5254
		public static PbDataPreload GetRootAsPbDataPreload(ByteBuffer _bb, PbDataPreload obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A34B RID: 41803 RVA: 0x002A7071 File Offset: 0x002A5271
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A34C RID: 41804 RVA: 0x002A7080 File Offset: 0x002A5280
		public PbDataPreload __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170024D1 RID: 9425
		// (get) Token: 0x0600A34D RID: 41805 RVA: 0x002A7090 File Offset: 0x002A5290
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

		// Token: 0x170024D2 RID: 9426
		// (get) Token: 0x0600A34E RID: 41806 RVA: 0x002A70CC File Offset: 0x002A52CC
		public int MapId
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

		// Token: 0x170024D3 RID: 9427
		// (get) Token: 0x0600A34F RID: 41807 RVA: 0x002A7108 File Offset: 0x002A5308
		public int PbDataId
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

		// Token: 0x0600A350 RID: 41808 RVA: 0x002A7144 File Offset: 0x002A5344
		public string ActorClass(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170024D4 RID: 9428
		// (get) Token: 0x0600A351 RID: 41809 RVA: 0x002A7180 File Offset: 0x002A5380
		public int ActorClassLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A352 RID: 41810 RVA: 0x002A71AC File Offset: 0x002A53AC
		public string Animations(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170024D5 RID: 9429
		// (get) Token: 0x0600A353 RID: 41811 RVA: 0x002A71E8 File Offset: 0x002A53E8
		public int AnimationsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A354 RID: 41812 RVA: 0x002A7214 File Offset: 0x002A5414
		public string Effects(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170024D6 RID: 9430
		// (get) Token: 0x0600A355 RID: 41813 RVA: 0x002A7250 File Offset: 0x002A5450
		public int EffectsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A356 RID: 41814 RVA: 0x002A727C File Offset: 0x002A547C
		public string Audios(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170024D7 RID: 9431
		// (get) Token: 0x0600A357 RID: 41815 RVA: 0x002A72B8 File Offset: 0x002A54B8
		public int AudiosLength
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

		// Token: 0x0600A358 RID: 41816 RVA: 0x002A72E4 File Offset: 0x002A54E4
		public string Meshes(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170024D8 RID: 9432
		// (get) Token: 0x0600A359 RID: 41817 RVA: 0x002A7320 File Offset: 0x002A5520
		public int MeshesLength
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

		// Token: 0x0600A35A RID: 41818 RVA: 0x002A734C File Offset: 0x002A554C
		public string Materials(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170024D9 RID: 9433
		// (get) Token: 0x0600A35B RID: 41819 RVA: 0x002A7388 File Offset: 0x002A5588
		public int MaterialsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A35C RID: 41820 RVA: 0x002A73B4 File Offset: 0x002A55B4
		public string AnimationBlueprints(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170024DA RID: 9434
		// (get) Token: 0x0600A35D RID: 41821 RVA: 0x002A73F0 File Offset: 0x002A55F0
		public int AnimationBlueprintsLength
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

		// Token: 0x0600A35E RID: 41822 RVA: 0x002A741C File Offset: 0x002A561C
		public string Others(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170024DB RID: 9435
		// (get) Token: 0x0600A35F RID: 41823 RVA: 0x002A7458 File Offset: 0x002A5658
		public int OthersLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A360 RID: 41824 RVA: 0x002A7484 File Offset: 0x002A5684
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ActorClassIter()或GetActorClassBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ActorClass()
		{
			return this.ActorClassIter().ToArray<string>();
		}

		// Token: 0x0600A361 RID: 41825 RVA: 0x002A7491 File Offset: 0x002A5691
		[NullableContext(1)]
		public readonly IEnumerable<string> ActorClassIter()
		{
			PbDataPreload.<ActorClassIter>d__39 <ActorClassIter>d__ = new PbDataPreload.<ActorClassIter>d__39(-2);
			<ActorClassIter>d__.<>3__<>4__this = this;
			return <ActorClassIter>d__;
		}

		// Token: 0x0600A362 RID: 41826 RVA: 0x002A74A6 File Offset: 0x002A56A6
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AnimationBlueprintsIter()或GetAnimationBlueprintsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AnimationBlueprints()
		{
			return this.AnimationBlueprintsIter().ToArray<string>();
		}

		// Token: 0x0600A363 RID: 41827 RVA: 0x002A74B3 File Offset: 0x002A56B3
		[NullableContext(1)]
		public readonly IEnumerable<string> AnimationBlueprintsIter()
		{
			PbDataPreload.<AnimationBlueprintsIter>d__41 <AnimationBlueprintsIter>d__ = new PbDataPreload.<AnimationBlueprintsIter>d__41(-2);
			<AnimationBlueprintsIter>d__.<>3__<>4__this = this;
			return <AnimationBlueprintsIter>d__;
		}

		// Token: 0x0600A364 RID: 41828 RVA: 0x002A74C8 File Offset: 0x002A56C8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AnimationsIter()或GetAnimationsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Animations()
		{
			return this.AnimationsIter().ToArray<string>();
		}

		// Token: 0x0600A365 RID: 41829 RVA: 0x002A74D5 File Offset: 0x002A56D5
		[NullableContext(1)]
		public readonly IEnumerable<string> AnimationsIter()
		{
			PbDataPreload.<AnimationsIter>d__43 <AnimationsIter>d__ = new PbDataPreload.<AnimationsIter>d__43(-2);
			<AnimationsIter>d__.<>3__<>4__this = this;
			return <AnimationsIter>d__;
		}

		// Token: 0x0600A366 RID: 41830 RVA: 0x002A74EA File Offset: 0x002A56EA
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AudiosIter()或GetAudiosBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Audios()
		{
			return this.AudiosIter().ToArray<string>();
		}

		// Token: 0x0600A367 RID: 41831 RVA: 0x002A74F7 File Offset: 0x002A56F7
		[NullableContext(1)]
		public readonly IEnumerable<string> AudiosIter()
		{
			PbDataPreload.<AudiosIter>d__45 <AudiosIter>d__ = new PbDataPreload.<AudiosIter>d__45(-2);
			<AudiosIter>d__.<>3__<>4__this = this;
			return <AudiosIter>d__;
		}

		// Token: 0x0600A368 RID: 41832 RVA: 0x002A750C File Offset: 0x002A570C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectsIter()或GetEffectsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Effects()
		{
			return this.EffectsIter().ToArray<string>();
		}

		// Token: 0x0600A369 RID: 41833 RVA: 0x002A7519 File Offset: 0x002A5719
		[NullableContext(1)]
		public readonly IEnumerable<string> EffectsIter()
		{
			PbDataPreload.<EffectsIter>d__47 <EffectsIter>d__ = new PbDataPreload.<EffectsIter>d__47(-2);
			<EffectsIter>d__.<>3__<>4__this = this;
			return <EffectsIter>d__;
		}

		// Token: 0x0600A36A RID: 41834 RVA: 0x002A752E File Offset: 0x002A572E
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MaterialsIter()或GetMaterialsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Materials()
		{
			return this.MaterialsIter().ToArray<string>();
		}

		// Token: 0x0600A36B RID: 41835 RVA: 0x002A753B File Offset: 0x002A573B
		[NullableContext(1)]
		public readonly IEnumerable<string> MaterialsIter()
		{
			PbDataPreload.<MaterialsIter>d__49 <MaterialsIter>d__ = new PbDataPreload.<MaterialsIter>d__49(-2);
			<MaterialsIter>d__.<>3__<>4__this = this;
			return <MaterialsIter>d__;
		}

		// Token: 0x0600A36C RID: 41836 RVA: 0x002A7550 File Offset: 0x002A5750
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MeshesIter()或GetMeshesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Meshes()
		{
			return this.MeshesIter().ToArray<string>();
		}

		// Token: 0x0600A36D RID: 41837 RVA: 0x002A755D File Offset: 0x002A575D
		[NullableContext(1)]
		public readonly IEnumerable<string> MeshesIter()
		{
			PbDataPreload.<MeshesIter>d__51 <MeshesIter>d__ = new PbDataPreload.<MeshesIter>d__51(-2);
			<MeshesIter>d__.<>3__<>4__this = this;
			return <MeshesIter>d__;
		}

		// Token: 0x0600A36E RID: 41838 RVA: 0x002A7572 File Offset: 0x002A5772
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OthersIter()或GetOthersBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Others()
		{
			return this.OthersIter().ToArray<string>();
		}

		// Token: 0x0600A36F RID: 41839 RVA: 0x002A757F File Offset: 0x002A577F
		[NullableContext(1)]
		public readonly IEnumerable<string> OthersIter()
		{
			PbDataPreload.<OthersIter>d__53 <OthersIter>d__ = new PbDataPreload.<OthersIter>d__53(-2);
			<OthersIter>d__.<>3__<>4__this = this;
			return <OthersIter>d__;
		}

		// Token: 0x04004F6B RID: 20331
		private Table __p;
	}
}
