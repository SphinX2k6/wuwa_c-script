using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EF2 RID: 3826
	public struct ModelConfigPreload : IFlatbufferObject
	{
		// Token: 0x17001F86 RID: 8070
		// (get) Token: 0x06009A66 RID: 39526 RVA: 0x002A3C1D File Offset: 0x002A1E1D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009A67 RID: 39527 RVA: 0x002A3C2A File Offset: 0x002A1E2A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009A68 RID: 39528 RVA: 0x002A3C34 File Offset: 0x002A1E34
		public static ModelConfigPreload GetRootAsModelConfigPreload(ByteBuffer _bb)
		{
			return ModelConfigPreload.GetRootAsModelConfigPreload(_bb, default(ModelConfigPreload));
		}

		// Token: 0x06009A69 RID: 39529 RVA: 0x002A3C50 File Offset: 0x002A1E50
		public static ModelConfigPreload GetRootAsModelConfigPreload(ByteBuffer _bb, ModelConfigPreload obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009A6A RID: 39530 RVA: 0x002A3C6D File Offset: 0x002A1E6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009A6B RID: 39531 RVA: 0x002A3C7C File Offset: 0x002A1E7C
		public ModelConfigPreload __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F87 RID: 8071
		// (get) Token: 0x06009A6C RID: 39532 RVA: 0x002A3C8C File Offset: 0x002A1E8C
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

		// Token: 0x17001F88 RID: 8072
		// (get) Token: 0x06009A6D RID: 39533 RVA: 0x002A3CC8 File Offset: 0x002A1EC8
		public string ActorClassPath
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009A6E RID: 39534 RVA: 0x002A3CFF File Offset: 0x002A1EFF
		public Span<byte> GetActorClassPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009A6F RID: 39535 RVA: 0x002A3D0E File Offset: 0x002A1F0E
		public byte[] GetActorClassPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06009A70 RID: 39536 RVA: 0x002A3D28 File Offset: 0x002A1F28
		public string ActorClass(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F89 RID: 8073
		// (get) Token: 0x06009A71 RID: 39537 RVA: 0x002A3D64 File Offset: 0x002A1F64
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

		// Token: 0x06009A72 RID: 39538 RVA: 0x002A3D90 File Offset: 0x002A1F90
		public string Animations(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F8A RID: 8074
		// (get) Token: 0x06009A73 RID: 39539 RVA: 0x002A3DCC File Offset: 0x002A1FCC
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

		// Token: 0x06009A74 RID: 39540 RVA: 0x002A3DF8 File Offset: 0x002A1FF8
		public string Effects(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F8B RID: 8075
		// (get) Token: 0x06009A75 RID: 39541 RVA: 0x002A3E34 File Offset: 0x002A2034
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

		// Token: 0x06009A76 RID: 39542 RVA: 0x002A3E60 File Offset: 0x002A2060
		public string Audios(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F8C RID: 8076
		// (get) Token: 0x06009A77 RID: 39543 RVA: 0x002A3E9C File Offset: 0x002A209C
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

		// Token: 0x06009A78 RID: 39544 RVA: 0x002A3EC8 File Offset: 0x002A20C8
		public string Meshes(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F8D RID: 8077
		// (get) Token: 0x06009A79 RID: 39545 RVA: 0x002A3F04 File Offset: 0x002A2104
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

		// Token: 0x06009A7A RID: 39546 RVA: 0x002A3F30 File Offset: 0x002A2130
		public string Materials(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F8E RID: 8078
		// (get) Token: 0x06009A7B RID: 39547 RVA: 0x002A3F6C File Offset: 0x002A216C
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

		// Token: 0x06009A7C RID: 39548 RVA: 0x002A3F98 File Offset: 0x002A2198
		public string AnimationBlueprints(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F8F RID: 8079
		// (get) Token: 0x06009A7D RID: 39549 RVA: 0x002A3FD4 File Offset: 0x002A21D4
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

		// Token: 0x06009A7E RID: 39550 RVA: 0x002A4000 File Offset: 0x002A2200
		public string Others(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F90 RID: 8080
		// (get) Token: 0x06009A7F RID: 39551 RVA: 0x002A403C File Offset: 0x002A223C
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

		// Token: 0x06009A80 RID: 39552 RVA: 0x002A4068 File Offset: 0x002A2268
		[NullableContext(1)]
		public string[] ActorClass()
		{
			return this.ActorClassIter().ToArray<string>();
		}

		// Token: 0x06009A81 RID: 39553 RVA: 0x002A4075 File Offset: 0x002A2275
		[NullableContext(1)]
		public IEnumerable<string> ActorClassIter()
		{
			ModelConfigPreload.<ActorClassIter>d__39 <ActorClassIter>d__ = new ModelConfigPreload.<ActorClassIter>d__39(-2);
			<ActorClassIter>d__.<>3__<>4__this = this;
			return <ActorClassIter>d__;
		}

		// Token: 0x06009A82 RID: 39554 RVA: 0x002A408A File Offset: 0x002A228A
		[NullableContext(1)]
		public string[] AnimationBlueprints()
		{
			return this.AnimationBlueprintsIter().ToArray<string>();
		}

		// Token: 0x06009A83 RID: 39555 RVA: 0x002A4097 File Offset: 0x002A2297
		[NullableContext(1)]
		public IEnumerable<string> AnimationBlueprintsIter()
		{
			ModelConfigPreload.<AnimationBlueprintsIter>d__41 <AnimationBlueprintsIter>d__ = new ModelConfigPreload.<AnimationBlueprintsIter>d__41(-2);
			<AnimationBlueprintsIter>d__.<>3__<>4__this = this;
			return <AnimationBlueprintsIter>d__;
		}

		// Token: 0x06009A84 RID: 39556 RVA: 0x002A40AC File Offset: 0x002A22AC
		[NullableContext(1)]
		public string[] Animations()
		{
			return this.AnimationsIter().ToArray<string>();
		}

		// Token: 0x06009A85 RID: 39557 RVA: 0x002A40B9 File Offset: 0x002A22B9
		[NullableContext(1)]
		public IEnumerable<string> AnimationsIter()
		{
			ModelConfigPreload.<AnimationsIter>d__43 <AnimationsIter>d__ = new ModelConfigPreload.<AnimationsIter>d__43(-2);
			<AnimationsIter>d__.<>3__<>4__this = this;
			return <AnimationsIter>d__;
		}

		// Token: 0x06009A86 RID: 39558 RVA: 0x002A40CE File Offset: 0x002A22CE
		[NullableContext(1)]
		public string[] Audios()
		{
			return this.AudiosIter().ToArray<string>();
		}

		// Token: 0x06009A87 RID: 39559 RVA: 0x002A40DB File Offset: 0x002A22DB
		[NullableContext(1)]
		public IEnumerable<string> AudiosIter()
		{
			ModelConfigPreload.<AudiosIter>d__45 <AudiosIter>d__ = new ModelConfigPreload.<AudiosIter>d__45(-2);
			<AudiosIter>d__.<>3__<>4__this = this;
			return <AudiosIter>d__;
		}

		// Token: 0x06009A88 RID: 39560 RVA: 0x002A40F0 File Offset: 0x002A22F0
		[NullableContext(1)]
		public string[] Effects()
		{
			return this.EffectsIter().ToArray<string>();
		}

		// Token: 0x06009A89 RID: 39561 RVA: 0x002A40FD File Offset: 0x002A22FD
		[NullableContext(1)]
		public IEnumerable<string> EffectsIter()
		{
			ModelConfigPreload.<EffectsIter>d__47 <EffectsIter>d__ = new ModelConfigPreload.<EffectsIter>d__47(-2);
			<EffectsIter>d__.<>3__<>4__this = this;
			return <EffectsIter>d__;
		}

		// Token: 0x06009A8A RID: 39562 RVA: 0x002A4112 File Offset: 0x002A2312
		[NullableContext(1)]
		public string[] Materials()
		{
			return this.MaterialsIter().ToArray<string>();
		}

		// Token: 0x06009A8B RID: 39563 RVA: 0x002A411F File Offset: 0x002A231F
		[NullableContext(1)]
		public IEnumerable<string> MaterialsIter()
		{
			ModelConfigPreload.<MaterialsIter>d__49 <MaterialsIter>d__ = new ModelConfigPreload.<MaterialsIter>d__49(-2);
			<MaterialsIter>d__.<>3__<>4__this = this;
			return <MaterialsIter>d__;
		}

		// Token: 0x06009A8C RID: 39564 RVA: 0x002A4134 File Offset: 0x002A2334
		[NullableContext(1)]
		public string[] Meshes()
		{
			return this.MeshesIter().ToArray<string>();
		}

		// Token: 0x06009A8D RID: 39565 RVA: 0x002A4141 File Offset: 0x002A2341
		[NullableContext(1)]
		public IEnumerable<string> MeshesIter()
		{
			ModelConfigPreload.<MeshesIter>d__51 <MeshesIter>d__ = new ModelConfigPreload.<MeshesIter>d__51(-2);
			<MeshesIter>d__.<>3__<>4__this = this;
			return <MeshesIter>d__;
		}

		// Token: 0x06009A8E RID: 39566 RVA: 0x002A4156 File Offset: 0x002A2356
		[NullableContext(1)]
		public string[] Others()
		{
			return this.OthersIter().ToArray<string>();
		}

		// Token: 0x06009A8F RID: 39567 RVA: 0x002A4163 File Offset: 0x002A2363
		[NullableContext(1)]
		public IEnumerable<string> OthersIter()
		{
			ModelConfigPreload.<OthersIter>d__53 <OthersIter>d__ = new ModelConfigPreload.<OthersIter>d__53(-2);
			<OthersIter>d__.<>3__<>4__this = this;
			return <OthersIter>d__;
		}

		// Token: 0x04005497 RID: 21655
		private Table __p;
	}
}
