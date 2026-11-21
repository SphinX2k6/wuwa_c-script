using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F9A RID: 3994
	public struct PbDataPreload : IFlatbufferObject
	{
		// Token: 0x17002536 RID: 9526
		// (get) Token: 0x0600A968 RID: 43368 RVA: 0x002C43C0 File Offset: 0x002C25C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A969 RID: 43369 RVA: 0x002C43CD File Offset: 0x002C25CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A96A RID: 43370 RVA: 0x002C43D4 File Offset: 0x002C25D4
		public static PbDataPreload GetRootAsPbDataPreload(ByteBuffer _bb)
		{
			return PbDataPreload.GetRootAsPbDataPreload(_bb, default(PbDataPreload));
		}

		// Token: 0x0600A96B RID: 43371 RVA: 0x002C43F0 File Offset: 0x002C25F0
		public static PbDataPreload GetRootAsPbDataPreload(ByteBuffer _bb, PbDataPreload obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A96C RID: 43372 RVA: 0x002C440D File Offset: 0x002C260D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A96D RID: 43373 RVA: 0x002C441C File Offset: 0x002C261C
		public PbDataPreload __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002537 RID: 9527
		// (get) Token: 0x0600A96E RID: 43374 RVA: 0x002C442C File Offset: 0x002C262C
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

		// Token: 0x17002538 RID: 9528
		// (get) Token: 0x0600A96F RID: 43375 RVA: 0x002C4468 File Offset: 0x002C2668
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

		// Token: 0x17002539 RID: 9529
		// (get) Token: 0x0600A970 RID: 43376 RVA: 0x002C44A4 File Offset: 0x002C26A4
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

		// Token: 0x0600A971 RID: 43377 RVA: 0x002C44E0 File Offset: 0x002C26E0
		public string ActorClass(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700253A RID: 9530
		// (get) Token: 0x0600A972 RID: 43378 RVA: 0x002C451C File Offset: 0x002C271C
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

		// Token: 0x0600A973 RID: 43379 RVA: 0x002C4548 File Offset: 0x002C2748
		public string Animations(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700253B RID: 9531
		// (get) Token: 0x0600A974 RID: 43380 RVA: 0x002C4584 File Offset: 0x002C2784
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

		// Token: 0x0600A975 RID: 43381 RVA: 0x002C45B0 File Offset: 0x002C27B0
		public string Effects(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700253C RID: 9532
		// (get) Token: 0x0600A976 RID: 43382 RVA: 0x002C45EC File Offset: 0x002C27EC
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

		// Token: 0x0600A977 RID: 43383 RVA: 0x002C4618 File Offset: 0x002C2818
		public string Audios(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700253D RID: 9533
		// (get) Token: 0x0600A978 RID: 43384 RVA: 0x002C4654 File Offset: 0x002C2854
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

		// Token: 0x0600A979 RID: 43385 RVA: 0x002C4680 File Offset: 0x002C2880
		public string Meshes(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700253E RID: 9534
		// (get) Token: 0x0600A97A RID: 43386 RVA: 0x002C46BC File Offset: 0x002C28BC
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

		// Token: 0x0600A97B RID: 43387 RVA: 0x002C46E8 File Offset: 0x002C28E8
		public string Materials(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700253F RID: 9535
		// (get) Token: 0x0600A97C RID: 43388 RVA: 0x002C4724 File Offset: 0x002C2924
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

		// Token: 0x0600A97D RID: 43389 RVA: 0x002C4750 File Offset: 0x002C2950
		public string AnimationBlueprints(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002540 RID: 9536
		// (get) Token: 0x0600A97E RID: 43390 RVA: 0x002C478C File Offset: 0x002C298C
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

		// Token: 0x0600A97F RID: 43391 RVA: 0x002C47B8 File Offset: 0x002C29B8
		public string Others(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002541 RID: 9537
		// (get) Token: 0x0600A980 RID: 43392 RVA: 0x002C47F4 File Offset: 0x002C29F4
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

		// Token: 0x0600A981 RID: 43393 RVA: 0x002C4820 File Offset: 0x002C2A20
		[NullableContext(1)]
		public string[] ActorClass()
		{
			return this.ActorClassIter().ToArray<string>();
		}

		// Token: 0x0600A982 RID: 43394 RVA: 0x002C482D File Offset: 0x002C2A2D
		[NullableContext(1)]
		public IEnumerable<string> ActorClassIter()
		{
			PbDataPreload.<ActorClassIter>d__39 <ActorClassIter>d__ = new PbDataPreload.<ActorClassIter>d__39(-2);
			<ActorClassIter>d__.<>3__<>4__this = this;
			return <ActorClassIter>d__;
		}

		// Token: 0x0600A983 RID: 43395 RVA: 0x002C4842 File Offset: 0x002C2A42
		[NullableContext(1)]
		public string[] AnimationBlueprints()
		{
			return this.AnimationBlueprintsIter().ToArray<string>();
		}

		// Token: 0x0600A984 RID: 43396 RVA: 0x002C484F File Offset: 0x002C2A4F
		[NullableContext(1)]
		public IEnumerable<string> AnimationBlueprintsIter()
		{
			PbDataPreload.<AnimationBlueprintsIter>d__41 <AnimationBlueprintsIter>d__ = new PbDataPreload.<AnimationBlueprintsIter>d__41(-2);
			<AnimationBlueprintsIter>d__.<>3__<>4__this = this;
			return <AnimationBlueprintsIter>d__;
		}

		// Token: 0x0600A985 RID: 43397 RVA: 0x002C4864 File Offset: 0x002C2A64
		[NullableContext(1)]
		public string[] Animations()
		{
			return this.AnimationsIter().ToArray<string>();
		}

		// Token: 0x0600A986 RID: 43398 RVA: 0x002C4871 File Offset: 0x002C2A71
		[NullableContext(1)]
		public IEnumerable<string> AnimationsIter()
		{
			PbDataPreload.<AnimationsIter>d__43 <AnimationsIter>d__ = new PbDataPreload.<AnimationsIter>d__43(-2);
			<AnimationsIter>d__.<>3__<>4__this = this;
			return <AnimationsIter>d__;
		}

		// Token: 0x0600A987 RID: 43399 RVA: 0x002C4886 File Offset: 0x002C2A86
		[NullableContext(1)]
		public string[] Audios()
		{
			return this.AudiosIter().ToArray<string>();
		}

		// Token: 0x0600A988 RID: 43400 RVA: 0x002C4893 File Offset: 0x002C2A93
		[NullableContext(1)]
		public IEnumerable<string> AudiosIter()
		{
			PbDataPreload.<AudiosIter>d__45 <AudiosIter>d__ = new PbDataPreload.<AudiosIter>d__45(-2);
			<AudiosIter>d__.<>3__<>4__this = this;
			return <AudiosIter>d__;
		}

		// Token: 0x0600A989 RID: 43401 RVA: 0x002C48A8 File Offset: 0x002C2AA8
		[NullableContext(1)]
		public string[] Effects()
		{
			return this.EffectsIter().ToArray<string>();
		}

		// Token: 0x0600A98A RID: 43402 RVA: 0x002C48B5 File Offset: 0x002C2AB5
		[NullableContext(1)]
		public IEnumerable<string> EffectsIter()
		{
			PbDataPreload.<EffectsIter>d__47 <EffectsIter>d__ = new PbDataPreload.<EffectsIter>d__47(-2);
			<EffectsIter>d__.<>3__<>4__this = this;
			return <EffectsIter>d__;
		}

		// Token: 0x0600A98B RID: 43403 RVA: 0x002C48CA File Offset: 0x002C2ACA
		[NullableContext(1)]
		public string[] Materials()
		{
			return this.MaterialsIter().ToArray<string>();
		}

		// Token: 0x0600A98C RID: 43404 RVA: 0x002C48D7 File Offset: 0x002C2AD7
		[NullableContext(1)]
		public IEnumerable<string> MaterialsIter()
		{
			PbDataPreload.<MaterialsIter>d__49 <MaterialsIter>d__ = new PbDataPreload.<MaterialsIter>d__49(-2);
			<MaterialsIter>d__.<>3__<>4__this = this;
			return <MaterialsIter>d__;
		}

		// Token: 0x0600A98D RID: 43405 RVA: 0x002C48EC File Offset: 0x002C2AEC
		[NullableContext(1)]
		public string[] Meshes()
		{
			return this.MeshesIter().ToArray<string>();
		}

		// Token: 0x0600A98E RID: 43406 RVA: 0x002C48F9 File Offset: 0x002C2AF9
		[NullableContext(1)]
		public IEnumerable<string> MeshesIter()
		{
			PbDataPreload.<MeshesIter>d__51 <MeshesIter>d__ = new PbDataPreload.<MeshesIter>d__51(-2);
			<MeshesIter>d__.<>3__<>4__this = this;
			return <MeshesIter>d__;
		}

		// Token: 0x0600A98F RID: 43407 RVA: 0x002C490E File Offset: 0x002C2B0E
		[NullableContext(1)]
		public string[] Others()
		{
			return this.OthersIter().ToArray<string>();
		}

		// Token: 0x0600A990 RID: 43408 RVA: 0x002C491B File Offset: 0x002C2B1B
		[NullableContext(1)]
		public IEnumerable<string> OthersIter()
		{
			PbDataPreload.<OthersIter>d__53 <OthersIter>d__ = new PbDataPreload.<OthersIter>d__53(-2);
			<OthersIter>d__.<>3__<>4__this = this;
			return <OthersIter>d__;
		}

		// Token: 0x04005550 RID: 21840
		private Table __p;
	}
}
