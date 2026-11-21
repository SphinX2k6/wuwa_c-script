using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D1B RID: 3355
	public struct EntitySkillPreload : IFlatbufferObject
	{
		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x06006F9D RID: 28573 RVA: 0x00243488 File Offset: 0x00241688
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006F9E RID: 28574 RVA: 0x00243495 File Offset: 0x00241695
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006F9F RID: 28575 RVA: 0x0024349C File Offset: 0x0024169C
		public static EntitySkillPreload GetRootAsEntitySkillPreload(ByteBuffer _bb)
		{
			return EntitySkillPreload.GetRootAsEntitySkillPreload(_bb, default(EntitySkillPreload));
		}

		// Token: 0x06006FA0 RID: 28576 RVA: 0x002434B8 File Offset: 0x002416B8
		public static EntitySkillPreload GetRootAsEntitySkillPreload(ByteBuffer _bb, EntitySkillPreload obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006FA1 RID: 28577 RVA: 0x002434D5 File Offset: 0x002416D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006FA2 RID: 28578 RVA: 0x002434E4 File Offset: 0x002416E4
		public EntitySkillPreload __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x06006FA3 RID: 28579 RVA: 0x002434F4 File Offset: 0x002416F4
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

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06006FA4 RID: 28580 RVA: 0x00243530 File Offset: 0x00241730
		public int SkillId
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

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06006FA5 RID: 28581 RVA: 0x0024356C File Offset: 0x0024176C
		public string ActorBlueprint
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006FA6 RID: 28582 RVA: 0x002435A3 File Offset: 0x002417A3
		public Span<byte> GetActorBlueprintBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006FA7 RID: 28583 RVA: 0x002435B2 File Offset: 0x002417B2
		public byte[] GetActorBlueprintArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x06006FA8 RID: 28584 RVA: 0x002435CC File Offset: 0x002417CC
		public int LoadType
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

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x06006FA9 RID: 28585 RVA: 0x0024360C File Offset: 0x0024180C
		public bool IsCommon
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x06006FAA RID: 28586 RVA: 0x0024364C File Offset: 0x0024184C
		public bool HasMontagePath
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06006FAB RID: 28587 RVA: 0x0024368C File Offset: 0x0024188C
		public string ActorClass(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x06006FAC RID: 28588 RVA: 0x002436C8 File Offset: 0x002418C8
		public int ActorClassLength
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

		// Token: 0x06006FAD RID: 28589 RVA: 0x002436F4 File Offset: 0x002418F4
		public string Animations(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06006FAE RID: 28590 RVA: 0x00243730 File Offset: 0x00241930
		public int AnimationsLength
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

		// Token: 0x06006FAF RID: 28591 RVA: 0x0024375C File Offset: 0x0024195C
		public string Effects(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x06006FB0 RID: 28592 RVA: 0x00243798 File Offset: 0x00241998
		public int EffectsLength
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

		// Token: 0x06006FB1 RID: 28593 RVA: 0x002437C4 File Offset: 0x002419C4
		public string Audios(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x06006FB2 RID: 28594 RVA: 0x00243800 File Offset: 0x00241A00
		public int AudiosLength
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

		// Token: 0x06006FB3 RID: 28595 RVA: 0x0024382C File Offset: 0x00241A2C
		public string Meshes(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x06006FB4 RID: 28596 RVA: 0x00243868 File Offset: 0x00241A68
		public int MeshesLength
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

		// Token: 0x06006FB5 RID: 28597 RVA: 0x00243894 File Offset: 0x00241A94
		public string Materials(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x06006FB6 RID: 28598 RVA: 0x002438D0 File Offset: 0x00241AD0
		public int MaterialsLength
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

		// Token: 0x06006FB7 RID: 28599 RVA: 0x002438FC File Offset: 0x00241AFC
		public string AnimationBlueprints(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x06006FB8 RID: 28600 RVA: 0x00243938 File Offset: 0x00241B38
		public int AnimationBlueprintsLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006FB9 RID: 28601 RVA: 0x00243964 File Offset: 0x00241B64
		public string Others(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x06006FBA RID: 28602 RVA: 0x002439A0 File Offset: 0x00241BA0
		public int OthersLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006FBB RID: 28603 RVA: 0x002439CC File Offset: 0x00241BCC
		[NullableContext(1)]
		public string[] ActorClass()
		{
			return this.ActorClassIter().ToArray<string>();
		}

		// Token: 0x06006FBC RID: 28604 RVA: 0x002439D9 File Offset: 0x00241BD9
		[NullableContext(1)]
		public IEnumerable<string> ActorClassIter()
		{
			EntitySkillPreload.<ActorClassIter>d__47 <ActorClassIter>d__ = new EntitySkillPreload.<ActorClassIter>d__47(-2);
			<ActorClassIter>d__.<>3__<>4__this = this;
			return <ActorClassIter>d__;
		}

		// Token: 0x06006FBD RID: 28605 RVA: 0x002439EE File Offset: 0x00241BEE
		[NullableContext(1)]
		public string[] AnimationBlueprints()
		{
			return this.AnimationBlueprintsIter().ToArray<string>();
		}

		// Token: 0x06006FBE RID: 28606 RVA: 0x002439FB File Offset: 0x00241BFB
		[NullableContext(1)]
		public IEnumerable<string> AnimationBlueprintsIter()
		{
			EntitySkillPreload.<AnimationBlueprintsIter>d__49 <AnimationBlueprintsIter>d__ = new EntitySkillPreload.<AnimationBlueprintsIter>d__49(-2);
			<AnimationBlueprintsIter>d__.<>3__<>4__this = this;
			return <AnimationBlueprintsIter>d__;
		}

		// Token: 0x06006FBF RID: 28607 RVA: 0x00243A10 File Offset: 0x00241C10
		[NullableContext(1)]
		public string[] Animations()
		{
			return this.AnimationsIter().ToArray<string>();
		}

		// Token: 0x06006FC0 RID: 28608 RVA: 0x00243A1D File Offset: 0x00241C1D
		[NullableContext(1)]
		public IEnumerable<string> AnimationsIter()
		{
			EntitySkillPreload.<AnimationsIter>d__51 <AnimationsIter>d__ = new EntitySkillPreload.<AnimationsIter>d__51(-2);
			<AnimationsIter>d__.<>3__<>4__this = this;
			return <AnimationsIter>d__;
		}

		// Token: 0x06006FC1 RID: 28609 RVA: 0x00243A32 File Offset: 0x00241C32
		[NullableContext(1)]
		public string[] Audios()
		{
			return this.AudiosIter().ToArray<string>();
		}

		// Token: 0x06006FC2 RID: 28610 RVA: 0x00243A3F File Offset: 0x00241C3F
		[NullableContext(1)]
		public IEnumerable<string> AudiosIter()
		{
			EntitySkillPreload.<AudiosIter>d__53 <AudiosIter>d__ = new EntitySkillPreload.<AudiosIter>d__53(-2);
			<AudiosIter>d__.<>3__<>4__this = this;
			return <AudiosIter>d__;
		}

		// Token: 0x06006FC3 RID: 28611 RVA: 0x00243A54 File Offset: 0x00241C54
		[NullableContext(1)]
		public string[] Effects()
		{
			return this.EffectsIter().ToArray<string>();
		}

		// Token: 0x06006FC4 RID: 28612 RVA: 0x00243A61 File Offset: 0x00241C61
		[NullableContext(1)]
		public IEnumerable<string> EffectsIter()
		{
			EntitySkillPreload.<EffectsIter>d__55 <EffectsIter>d__ = new EntitySkillPreload.<EffectsIter>d__55(-2);
			<EffectsIter>d__.<>3__<>4__this = this;
			return <EffectsIter>d__;
		}

		// Token: 0x06006FC5 RID: 28613 RVA: 0x00243A76 File Offset: 0x00241C76
		[NullableContext(1)]
		public string[] Materials()
		{
			return this.MaterialsIter().ToArray<string>();
		}

		// Token: 0x06006FC6 RID: 28614 RVA: 0x00243A83 File Offset: 0x00241C83
		[NullableContext(1)]
		public IEnumerable<string> MaterialsIter()
		{
			EntitySkillPreload.<MaterialsIter>d__57 <MaterialsIter>d__ = new EntitySkillPreload.<MaterialsIter>d__57(-2);
			<MaterialsIter>d__.<>3__<>4__this = this;
			return <MaterialsIter>d__;
		}

		// Token: 0x06006FC7 RID: 28615 RVA: 0x00243A98 File Offset: 0x00241C98
		[NullableContext(1)]
		public string[] Meshes()
		{
			return this.MeshesIter().ToArray<string>();
		}

		// Token: 0x06006FC8 RID: 28616 RVA: 0x00243AA5 File Offset: 0x00241CA5
		[NullableContext(1)]
		public IEnumerable<string> MeshesIter()
		{
			EntitySkillPreload.<MeshesIter>d__59 <MeshesIter>d__ = new EntitySkillPreload.<MeshesIter>d__59(-2);
			<MeshesIter>d__.<>3__<>4__this = this;
			return <MeshesIter>d__;
		}

		// Token: 0x06006FC9 RID: 28617 RVA: 0x00243ABA File Offset: 0x00241CBA
		[NullableContext(1)]
		public string[] Others()
		{
			return this.OthersIter().ToArray<string>();
		}

		// Token: 0x06006FCA RID: 28618 RVA: 0x00243AC7 File Offset: 0x00241CC7
		[NullableContext(1)]
		public IEnumerable<string> OthersIter()
		{
			EntitySkillPreload.<OthersIter>d__61 <OthersIter>d__ = new EntitySkillPreload.<OthersIter>d__61(-2);
			<OthersIter>d__.<>3__<>4__this = this;
			return <OthersIter>d__;
		}

		// Token: 0x0400525B RID: 21083
		private Table __p;
	}
}
