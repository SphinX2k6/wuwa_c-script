using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001229 RID: 4649
	public struct StateMachinePreload : IFlatbufferObject
	{
		// Token: 0x17003BC5 RID: 15301
		// (get) Token: 0x0600E6BF RID: 59071 RVA: 0x0034CC8C File Offset: 0x0034AE8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E6C0 RID: 59072 RVA: 0x0034CC99 File Offset: 0x0034AE99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E6C1 RID: 59073 RVA: 0x0034CCA0 File Offset: 0x0034AEA0
		public static StateMachinePreload GetRootAsStateMachinePreload(ByteBuffer _bb)
		{
			return StateMachinePreload.GetRootAsStateMachinePreload(_bb, default(StateMachinePreload));
		}

		// Token: 0x0600E6C2 RID: 59074 RVA: 0x0034CCBC File Offset: 0x0034AEBC
		public static StateMachinePreload GetRootAsStateMachinePreload(ByteBuffer _bb, StateMachinePreload obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E6C3 RID: 59075 RVA: 0x0034CCD9 File Offset: 0x0034AED9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E6C4 RID: 59076 RVA: 0x0034CCE8 File Offset: 0x0034AEE8
		public StateMachinePreload __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003BC6 RID: 15302
		// (get) Token: 0x0600E6C5 RID: 59077 RVA: 0x0034CCF8 File Offset: 0x0034AEF8
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

		// Token: 0x17003BC7 RID: 15303
		// (get) Token: 0x0600E6C6 RID: 59078 RVA: 0x0034CD34 File Offset: 0x0034AF34
		public string FsmKey
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

		// Token: 0x0600E6C7 RID: 59079 RVA: 0x0034CD6B File Offset: 0x0034AF6B
		public Span<byte> GetFsmKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E6C8 RID: 59080 RVA: 0x0034CD7A File Offset: 0x0034AF7A
		public byte[] GetFsmKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E6C9 RID: 59081 RVA: 0x0034CD94 File Offset: 0x0034AF94
		public string ActorClass(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BC8 RID: 15304
		// (get) Token: 0x0600E6CA RID: 59082 RVA: 0x0034CDD0 File Offset: 0x0034AFD0
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

		// Token: 0x0600E6CB RID: 59083 RVA: 0x0034CDFC File Offset: 0x0034AFFC
		public string Animations(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BC9 RID: 15305
		// (get) Token: 0x0600E6CC RID: 59084 RVA: 0x0034CE38 File Offset: 0x0034B038
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

		// Token: 0x0600E6CD RID: 59085 RVA: 0x0034CE64 File Offset: 0x0034B064
		public string Effects(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BCA RID: 15306
		// (get) Token: 0x0600E6CE RID: 59086 RVA: 0x0034CEA0 File Offset: 0x0034B0A0
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

		// Token: 0x0600E6CF RID: 59087 RVA: 0x0034CECC File Offset: 0x0034B0CC
		public string Audios(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BCB RID: 15307
		// (get) Token: 0x0600E6D0 RID: 59088 RVA: 0x0034CF08 File Offset: 0x0034B108
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

		// Token: 0x0600E6D1 RID: 59089 RVA: 0x0034CF34 File Offset: 0x0034B134
		public string Meshes(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BCC RID: 15308
		// (get) Token: 0x0600E6D2 RID: 59090 RVA: 0x0034CF70 File Offset: 0x0034B170
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

		// Token: 0x0600E6D3 RID: 59091 RVA: 0x0034CF9C File Offset: 0x0034B19C
		public string Materials(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BCD RID: 15309
		// (get) Token: 0x0600E6D4 RID: 59092 RVA: 0x0034CFD8 File Offset: 0x0034B1D8
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

		// Token: 0x0600E6D5 RID: 59093 RVA: 0x0034D004 File Offset: 0x0034B204
		public string AnimationBlueprints(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BCE RID: 15310
		// (get) Token: 0x0600E6D6 RID: 59094 RVA: 0x0034D040 File Offset: 0x0034B240
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

		// Token: 0x0600E6D7 RID: 59095 RVA: 0x0034D06C File Offset: 0x0034B26C
		public string Others(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BCF RID: 15311
		// (get) Token: 0x0600E6D8 RID: 59096 RVA: 0x0034D0A8 File Offset: 0x0034B2A8
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

		// Token: 0x0600E6D9 RID: 59097 RVA: 0x0034D0D4 File Offset: 0x0034B2D4
		[NullableContext(1)]
		public string[] ActorClass()
		{
			return this.ActorClassIter().ToArray<string>();
		}

		// Token: 0x0600E6DA RID: 59098 RVA: 0x0034D0E1 File Offset: 0x0034B2E1
		[NullableContext(1)]
		public IEnumerable<string> ActorClassIter()
		{
			StateMachinePreload.<ActorClassIter>d__39 <ActorClassIter>d__ = new StateMachinePreload.<ActorClassIter>d__39(-2);
			<ActorClassIter>d__.<>3__<>4__this = this;
			return <ActorClassIter>d__;
		}

		// Token: 0x0600E6DB RID: 59099 RVA: 0x0034D0F6 File Offset: 0x0034B2F6
		[NullableContext(1)]
		public string[] AnimationBlueprints()
		{
			return this.AnimationBlueprintsIter().ToArray<string>();
		}

		// Token: 0x0600E6DC RID: 59100 RVA: 0x0034D103 File Offset: 0x0034B303
		[NullableContext(1)]
		public IEnumerable<string> AnimationBlueprintsIter()
		{
			StateMachinePreload.<AnimationBlueprintsIter>d__41 <AnimationBlueprintsIter>d__ = new StateMachinePreload.<AnimationBlueprintsIter>d__41(-2);
			<AnimationBlueprintsIter>d__.<>3__<>4__this = this;
			return <AnimationBlueprintsIter>d__;
		}

		// Token: 0x0600E6DD RID: 59101 RVA: 0x0034D118 File Offset: 0x0034B318
		[NullableContext(1)]
		public string[] Animations()
		{
			return this.AnimationsIter().ToArray<string>();
		}

		// Token: 0x0600E6DE RID: 59102 RVA: 0x0034D125 File Offset: 0x0034B325
		[NullableContext(1)]
		public IEnumerable<string> AnimationsIter()
		{
			StateMachinePreload.<AnimationsIter>d__43 <AnimationsIter>d__ = new StateMachinePreload.<AnimationsIter>d__43(-2);
			<AnimationsIter>d__.<>3__<>4__this = this;
			return <AnimationsIter>d__;
		}

		// Token: 0x0600E6DF RID: 59103 RVA: 0x0034D13A File Offset: 0x0034B33A
		[NullableContext(1)]
		public string[] Audios()
		{
			return this.AudiosIter().ToArray<string>();
		}

		// Token: 0x0600E6E0 RID: 59104 RVA: 0x0034D147 File Offset: 0x0034B347
		[NullableContext(1)]
		public IEnumerable<string> AudiosIter()
		{
			StateMachinePreload.<AudiosIter>d__45 <AudiosIter>d__ = new StateMachinePreload.<AudiosIter>d__45(-2);
			<AudiosIter>d__.<>3__<>4__this = this;
			return <AudiosIter>d__;
		}

		// Token: 0x0600E6E1 RID: 59105 RVA: 0x0034D15C File Offset: 0x0034B35C
		[NullableContext(1)]
		public string[] Effects()
		{
			return this.EffectsIter().ToArray<string>();
		}

		// Token: 0x0600E6E2 RID: 59106 RVA: 0x0034D169 File Offset: 0x0034B369
		[NullableContext(1)]
		public IEnumerable<string> EffectsIter()
		{
			StateMachinePreload.<EffectsIter>d__47 <EffectsIter>d__ = new StateMachinePreload.<EffectsIter>d__47(-2);
			<EffectsIter>d__.<>3__<>4__this = this;
			return <EffectsIter>d__;
		}

		// Token: 0x0600E6E3 RID: 59107 RVA: 0x0034D17E File Offset: 0x0034B37E
		[NullableContext(1)]
		public string[] Materials()
		{
			return this.MaterialsIter().ToArray<string>();
		}

		// Token: 0x0600E6E4 RID: 59108 RVA: 0x0034D18B File Offset: 0x0034B38B
		[NullableContext(1)]
		public IEnumerable<string> MaterialsIter()
		{
			StateMachinePreload.<MaterialsIter>d__49 <MaterialsIter>d__ = new StateMachinePreload.<MaterialsIter>d__49(-2);
			<MaterialsIter>d__.<>3__<>4__this = this;
			return <MaterialsIter>d__;
		}

		// Token: 0x0600E6E5 RID: 59109 RVA: 0x0034D1A0 File Offset: 0x0034B3A0
		[NullableContext(1)]
		public string[] Meshes()
		{
			return this.MeshesIter().ToArray<string>();
		}

		// Token: 0x0600E6E6 RID: 59110 RVA: 0x0034D1AD File Offset: 0x0034B3AD
		[NullableContext(1)]
		public IEnumerable<string> MeshesIter()
		{
			StateMachinePreload.<MeshesIter>d__51 <MeshesIter>d__ = new StateMachinePreload.<MeshesIter>d__51(-2);
			<MeshesIter>d__.<>3__<>4__this = this;
			return <MeshesIter>d__;
		}

		// Token: 0x0600E6E7 RID: 59111 RVA: 0x0034D1C2 File Offset: 0x0034B3C2
		[NullableContext(1)]
		public string[] Others()
		{
			return this.OthersIter().ToArray<string>();
		}

		// Token: 0x0600E6E8 RID: 59112 RVA: 0x0034D1CF File Offset: 0x0034B3CF
		[NullableContext(1)]
		public IEnumerable<string> OthersIter()
		{
			StateMachinePreload.<OthersIter>d__53 <OthersIter>d__ = new StateMachinePreload.<OthersIter>d__53(-2);
			<OthersIter>d__.<>3__<>4__this = this;
			return <OthersIter>d__;
		}

		// Token: 0x0400586A RID: 22634
		private Table __p;
	}
}
