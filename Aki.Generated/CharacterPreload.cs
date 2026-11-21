using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C46 RID: 3142
	public struct CharacterPreload : IFlatbufferObject
	{
		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x0600589A RID: 22682 RVA: 0x002103E0 File Offset: 0x0020E5E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600589B RID: 22683 RVA: 0x002103ED File Offset: 0x0020E5ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600589C RID: 22684 RVA: 0x002103F4 File Offset: 0x0020E5F4
		public static CharacterPreload GetRootAsCharacterPreload(ByteBuffer _bb)
		{
			return CharacterPreload.GetRootAsCharacterPreload(_bb, default(CharacterPreload));
		}

		// Token: 0x0600589D RID: 22685 RVA: 0x00210410 File Offset: 0x0020E610
		public static CharacterPreload GetRootAsCharacterPreload(ByteBuffer _bb, CharacterPreload obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600589E RID: 22686 RVA: 0x0021042D File Offset: 0x0020E62D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600589F RID: 22687 RVA: 0x0021043C File Offset: 0x0020E63C
		public CharacterPreload __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x060058A0 RID: 22688 RVA: 0x0021044C File Offset: 0x0020E64C
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

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x060058A1 RID: 22689 RVA: 0x00210488 File Offset: 0x0020E688
		public int AiId
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

		// Token: 0x060058A2 RID: 22690 RVA: 0x002104C4 File Offset: 0x0020E6C4
		public string ActorClass(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x060058A3 RID: 22691 RVA: 0x00210500 File Offset: 0x0020E700
		public int ActorClassLength
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

		// Token: 0x060058A4 RID: 22692 RVA: 0x0021052C File Offset: 0x0020E72C
		public string Animations(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x060058A5 RID: 22693 RVA: 0x00210568 File Offset: 0x0020E768
		public int AnimationsLength
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

		// Token: 0x060058A6 RID: 22694 RVA: 0x00210594 File Offset: 0x0020E794
		public string Effects(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x060058A7 RID: 22695 RVA: 0x002105D0 File Offset: 0x0020E7D0
		public int EffectsLength
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

		// Token: 0x060058A8 RID: 22696 RVA: 0x002105FC File Offset: 0x0020E7FC
		public string Audios(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x060058A9 RID: 22697 RVA: 0x00210638 File Offset: 0x0020E838
		public int AudiosLength
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

		// Token: 0x060058AA RID: 22698 RVA: 0x00210664 File Offset: 0x0020E864
		public string Meshes(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x060058AB RID: 22699 RVA: 0x002106A0 File Offset: 0x0020E8A0
		public int MeshesLength
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

		// Token: 0x060058AC RID: 22700 RVA: 0x002106CC File Offset: 0x0020E8CC
		public string Materials(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x060058AD RID: 22701 RVA: 0x00210708 File Offset: 0x0020E908
		public int MaterialsLength
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

		// Token: 0x060058AE RID: 22702 RVA: 0x00210734 File Offset: 0x0020E934
		public string AnimationBlueprints(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x060058AF RID: 22703 RVA: 0x00210770 File Offset: 0x0020E970
		public int AnimationBlueprintsLength
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

		// Token: 0x060058B0 RID: 22704 RVA: 0x0021079C File Offset: 0x0020E99C
		public string Others(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x060058B1 RID: 22705 RVA: 0x002107D8 File Offset: 0x0020E9D8
		public int OthersLength
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

		// Token: 0x060058B2 RID: 22706 RVA: 0x00210804 File Offset: 0x0020EA04
		[NullableContext(1)]
		public string[] ActorClass()
		{
			return this.ActorClassIter().ToArray<string>();
		}

		// Token: 0x060058B3 RID: 22707 RVA: 0x00210811 File Offset: 0x0020EA11
		[NullableContext(1)]
		public IEnumerable<string> ActorClassIter()
		{
			CharacterPreload.<ActorClassIter>d__37 <ActorClassIter>d__ = new CharacterPreload.<ActorClassIter>d__37(-2);
			<ActorClassIter>d__.<>3__<>4__this = this;
			return <ActorClassIter>d__;
		}

		// Token: 0x060058B4 RID: 22708 RVA: 0x00210826 File Offset: 0x0020EA26
		[NullableContext(1)]
		public string[] AnimationBlueprints()
		{
			return this.AnimationBlueprintsIter().ToArray<string>();
		}

		// Token: 0x060058B5 RID: 22709 RVA: 0x00210833 File Offset: 0x0020EA33
		[NullableContext(1)]
		public IEnumerable<string> AnimationBlueprintsIter()
		{
			CharacterPreload.<AnimationBlueprintsIter>d__39 <AnimationBlueprintsIter>d__ = new CharacterPreload.<AnimationBlueprintsIter>d__39(-2);
			<AnimationBlueprintsIter>d__.<>3__<>4__this = this;
			return <AnimationBlueprintsIter>d__;
		}

		// Token: 0x060058B6 RID: 22710 RVA: 0x00210848 File Offset: 0x0020EA48
		[NullableContext(1)]
		public string[] Animations()
		{
			return this.AnimationsIter().ToArray<string>();
		}

		// Token: 0x060058B7 RID: 22711 RVA: 0x00210855 File Offset: 0x0020EA55
		[NullableContext(1)]
		public IEnumerable<string> AnimationsIter()
		{
			CharacterPreload.<AnimationsIter>d__41 <AnimationsIter>d__ = new CharacterPreload.<AnimationsIter>d__41(-2);
			<AnimationsIter>d__.<>3__<>4__this = this;
			return <AnimationsIter>d__;
		}

		// Token: 0x060058B8 RID: 22712 RVA: 0x0021086A File Offset: 0x0020EA6A
		[NullableContext(1)]
		public string[] Audios()
		{
			return this.AudiosIter().ToArray<string>();
		}

		// Token: 0x060058B9 RID: 22713 RVA: 0x00210877 File Offset: 0x0020EA77
		[NullableContext(1)]
		public IEnumerable<string> AudiosIter()
		{
			CharacterPreload.<AudiosIter>d__43 <AudiosIter>d__ = new CharacterPreload.<AudiosIter>d__43(-2);
			<AudiosIter>d__.<>3__<>4__this = this;
			return <AudiosIter>d__;
		}

		// Token: 0x060058BA RID: 22714 RVA: 0x0021088C File Offset: 0x0020EA8C
		[NullableContext(1)]
		public string[] Effects()
		{
			return this.EffectsIter().ToArray<string>();
		}

		// Token: 0x060058BB RID: 22715 RVA: 0x00210899 File Offset: 0x0020EA99
		[NullableContext(1)]
		public IEnumerable<string> EffectsIter()
		{
			CharacterPreload.<EffectsIter>d__45 <EffectsIter>d__ = new CharacterPreload.<EffectsIter>d__45(-2);
			<EffectsIter>d__.<>3__<>4__this = this;
			return <EffectsIter>d__;
		}

		// Token: 0x060058BC RID: 22716 RVA: 0x002108AE File Offset: 0x0020EAAE
		[NullableContext(1)]
		public string[] Materials()
		{
			return this.MaterialsIter().ToArray<string>();
		}

		// Token: 0x060058BD RID: 22717 RVA: 0x002108BB File Offset: 0x0020EABB
		[NullableContext(1)]
		public IEnumerable<string> MaterialsIter()
		{
			CharacterPreload.<MaterialsIter>d__47 <MaterialsIter>d__ = new CharacterPreload.<MaterialsIter>d__47(-2);
			<MaterialsIter>d__.<>3__<>4__this = this;
			return <MaterialsIter>d__;
		}

		// Token: 0x060058BE RID: 22718 RVA: 0x002108D0 File Offset: 0x0020EAD0
		[NullableContext(1)]
		public string[] Meshes()
		{
			return this.MeshesIter().ToArray<string>();
		}

		// Token: 0x060058BF RID: 22719 RVA: 0x002108DD File Offset: 0x0020EADD
		[NullableContext(1)]
		public IEnumerable<string> MeshesIter()
		{
			CharacterPreload.<MeshesIter>d__49 <MeshesIter>d__ = new CharacterPreload.<MeshesIter>d__49(-2);
			<MeshesIter>d__.<>3__<>4__this = this;
			return <MeshesIter>d__;
		}

		// Token: 0x060058C0 RID: 22720 RVA: 0x002108F2 File Offset: 0x0020EAF2
		[NullableContext(1)]
		public string[] Others()
		{
			return this.OthersIter().ToArray<string>();
		}

		// Token: 0x060058C1 RID: 22721 RVA: 0x002108FF File Offset: 0x0020EAFF
		[NullableContext(1)]
		public IEnumerable<string> OthersIter()
		{
			CharacterPreload.<OthersIter>d__51 <OthersIter>d__ = new CharacterPreload.<OthersIter>d__51(-2);
			<OthersIter>d__.<>3__<>4__this = this;
			return <OthersIter>d__;
		}

		// Token: 0x04005148 RID: 20808
		private Table __p;
	}
}
