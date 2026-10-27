using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010F3 RID: 4339
	public struct StateMachinePreload : IFlatbufferObject
	{
		// Token: 0x1700386F RID: 14447
		// (get) Token: 0x0600D974 RID: 55668 RVA: 0x00321724 File Offset: 0x0031F924
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D975 RID: 55669 RVA: 0x00321731 File Offset: 0x0031F931
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D976 RID: 55670 RVA: 0x00321738 File Offset: 0x0031F938
		public static StateMachinePreload GetRootAsStateMachinePreload(ByteBuffer _bb)
		{
			return StateMachinePreload.GetRootAsStateMachinePreload(_bb, default(StateMachinePreload));
		}

		// Token: 0x0600D977 RID: 55671 RVA: 0x00321754 File Offset: 0x0031F954
		public static StateMachinePreload GetRootAsStateMachinePreload(ByteBuffer _bb, StateMachinePreload obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D978 RID: 55672 RVA: 0x00321771 File Offset: 0x0031F971
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D979 RID: 55673 RVA: 0x00321780 File Offset: 0x0031F980
		public StateMachinePreload __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003870 RID: 14448
		// (get) Token: 0x0600D97A RID: 55674 RVA: 0x00321790 File Offset: 0x0031F990
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

		// Token: 0x17003871 RID: 14449
		// (get) Token: 0x0600D97B RID: 55675 RVA: 0x003217CC File Offset: 0x0031F9CC
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

		// Token: 0x0600D97C RID: 55676 RVA: 0x00321803 File Offset: 0x0031FA03
		public Span<byte> GetFsmKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D97D RID: 55677 RVA: 0x00321812 File Offset: 0x0031FA12
		public byte[] GetFsmKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D97E RID: 55678 RVA: 0x0032182C File Offset: 0x0031FA2C
		public string ActorClass(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003872 RID: 14450
		// (get) Token: 0x0600D97F RID: 55679 RVA: 0x00321868 File Offset: 0x0031FA68
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

		// Token: 0x0600D980 RID: 55680 RVA: 0x00321894 File Offset: 0x0031FA94
		public string Animations(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003873 RID: 14451
		// (get) Token: 0x0600D981 RID: 55681 RVA: 0x003218D0 File Offset: 0x0031FAD0
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

		// Token: 0x0600D982 RID: 55682 RVA: 0x003218FC File Offset: 0x0031FAFC
		public string Effects(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003874 RID: 14452
		// (get) Token: 0x0600D983 RID: 55683 RVA: 0x00321938 File Offset: 0x0031FB38
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

		// Token: 0x0600D984 RID: 55684 RVA: 0x00321964 File Offset: 0x0031FB64
		public string Audios(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003875 RID: 14453
		// (get) Token: 0x0600D985 RID: 55685 RVA: 0x003219A0 File Offset: 0x0031FBA0
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

		// Token: 0x0600D986 RID: 55686 RVA: 0x003219CC File Offset: 0x0031FBCC
		public string Meshes(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003876 RID: 14454
		// (get) Token: 0x0600D987 RID: 55687 RVA: 0x00321A08 File Offset: 0x0031FC08
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

		// Token: 0x0600D988 RID: 55688 RVA: 0x00321A34 File Offset: 0x0031FC34
		public string Materials(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003877 RID: 14455
		// (get) Token: 0x0600D989 RID: 55689 RVA: 0x00321A70 File Offset: 0x0031FC70
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

		// Token: 0x0600D98A RID: 55690 RVA: 0x00321A9C File Offset: 0x0031FC9C
		public string AnimationBlueprints(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003878 RID: 14456
		// (get) Token: 0x0600D98B RID: 55691 RVA: 0x00321AD8 File Offset: 0x0031FCD8
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

		// Token: 0x0600D98C RID: 55692 RVA: 0x00321B04 File Offset: 0x0031FD04
		public string Others(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003879 RID: 14457
		// (get) Token: 0x0600D98D RID: 55693 RVA: 0x00321B40 File Offset: 0x0031FD40
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

		// Token: 0x0600D98E RID: 55694 RVA: 0x00321B6C File Offset: 0x0031FD6C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ActorClassIter()或GetActorClassBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ActorClass()
		{
			return this.ActorClassIter().ToArray<string>();
		}

		// Token: 0x0600D98F RID: 55695 RVA: 0x00321B79 File Offset: 0x0031FD79
		[NullableContext(1)]
		public readonly IEnumerable<string> ActorClassIter()
		{
			StateMachinePreload.<ActorClassIter>d__39 <ActorClassIter>d__ = new StateMachinePreload.<ActorClassIter>d__39(-2);
			<ActorClassIter>d__.<>3__<>4__this = this;
			return <ActorClassIter>d__;
		}

		// Token: 0x0600D990 RID: 55696 RVA: 0x00321B8E File Offset: 0x0031FD8E
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AnimationBlueprintsIter()或GetAnimationBlueprintsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AnimationBlueprints()
		{
			return this.AnimationBlueprintsIter().ToArray<string>();
		}

		// Token: 0x0600D991 RID: 55697 RVA: 0x00321B9B File Offset: 0x0031FD9B
		[NullableContext(1)]
		public readonly IEnumerable<string> AnimationBlueprintsIter()
		{
			StateMachinePreload.<AnimationBlueprintsIter>d__41 <AnimationBlueprintsIter>d__ = new StateMachinePreload.<AnimationBlueprintsIter>d__41(-2);
			<AnimationBlueprintsIter>d__.<>3__<>4__this = this;
			return <AnimationBlueprintsIter>d__;
		}

		// Token: 0x0600D992 RID: 55698 RVA: 0x00321BB0 File Offset: 0x0031FDB0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AnimationsIter()或GetAnimationsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Animations()
		{
			return this.AnimationsIter().ToArray<string>();
		}

		// Token: 0x0600D993 RID: 55699 RVA: 0x00321BBD File Offset: 0x0031FDBD
		[NullableContext(1)]
		public readonly IEnumerable<string> AnimationsIter()
		{
			StateMachinePreload.<AnimationsIter>d__43 <AnimationsIter>d__ = new StateMachinePreload.<AnimationsIter>d__43(-2);
			<AnimationsIter>d__.<>3__<>4__this = this;
			return <AnimationsIter>d__;
		}

		// Token: 0x0600D994 RID: 55700 RVA: 0x00321BD2 File Offset: 0x0031FDD2
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AudiosIter()或GetAudiosBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Audios()
		{
			return this.AudiosIter().ToArray<string>();
		}

		// Token: 0x0600D995 RID: 55701 RVA: 0x00321BDF File Offset: 0x0031FDDF
		[NullableContext(1)]
		public readonly IEnumerable<string> AudiosIter()
		{
			StateMachinePreload.<AudiosIter>d__45 <AudiosIter>d__ = new StateMachinePreload.<AudiosIter>d__45(-2);
			<AudiosIter>d__.<>3__<>4__this = this;
			return <AudiosIter>d__;
		}

		// Token: 0x0600D996 RID: 55702 RVA: 0x00321BF4 File Offset: 0x0031FDF4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectsIter()或GetEffectsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Effects()
		{
			return this.EffectsIter().ToArray<string>();
		}

		// Token: 0x0600D997 RID: 55703 RVA: 0x00321C01 File Offset: 0x0031FE01
		[NullableContext(1)]
		public readonly IEnumerable<string> EffectsIter()
		{
			StateMachinePreload.<EffectsIter>d__47 <EffectsIter>d__ = new StateMachinePreload.<EffectsIter>d__47(-2);
			<EffectsIter>d__.<>3__<>4__this = this;
			return <EffectsIter>d__;
		}

		// Token: 0x0600D998 RID: 55704 RVA: 0x00321C16 File Offset: 0x0031FE16
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MaterialsIter()或GetMaterialsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Materials()
		{
			return this.MaterialsIter().ToArray<string>();
		}

		// Token: 0x0600D999 RID: 55705 RVA: 0x00321C23 File Offset: 0x0031FE23
		[NullableContext(1)]
		public readonly IEnumerable<string> MaterialsIter()
		{
			StateMachinePreload.<MaterialsIter>d__49 <MaterialsIter>d__ = new StateMachinePreload.<MaterialsIter>d__49(-2);
			<MaterialsIter>d__.<>3__<>4__this = this;
			return <MaterialsIter>d__;
		}

		// Token: 0x0600D99A RID: 55706 RVA: 0x00321C38 File Offset: 0x0031FE38
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MeshesIter()或GetMeshesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Meshes()
		{
			return this.MeshesIter().ToArray<string>();
		}

		// Token: 0x0600D99B RID: 55707 RVA: 0x00321C45 File Offset: 0x0031FE45
		[NullableContext(1)]
		public readonly IEnumerable<string> MeshesIter()
		{
			StateMachinePreload.<MeshesIter>d__51 <MeshesIter>d__ = new StateMachinePreload.<MeshesIter>d__51(-2);
			<MeshesIter>d__.<>3__<>4__this = this;
			return <MeshesIter>d__;
		}

		// Token: 0x0600D99C RID: 55708 RVA: 0x00321C5A File Offset: 0x0031FE5A
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OthersIter()或GetOthersBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Others()
		{
			return this.OthersIter().ToArray<string>();
		}

		// Token: 0x0600D99D RID: 55709 RVA: 0x00321C67 File Offset: 0x0031FE67
		[NullableContext(1)]
		public readonly IEnumerable<string> OthersIter()
		{
			StateMachinePreload.<OthersIter>d__53 <OthersIter>d__ = new StateMachinePreload.<OthersIter>d__53(-2);
			<OthersIter>d__.<>3__<>4__this = this;
			return <OthersIter>d__;
		}

		// Token: 0x04005227 RID: 21031
		private Table __p;
	}
}
