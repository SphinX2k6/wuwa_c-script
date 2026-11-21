using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02003635 RID: 13877
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class WuWaGoGridMoveParticipant : IWuWaGoGridMoveParticipant
	{
		// Token: 0x17004964 RID: 18788
		// (get) Token: 0x06024020 RID: 147488 RVA: 0x00A333CC File Offset: 0x00A315CC
		// (set) Token: 0x06024021 RID: 147489 RVA: 0x00A333D4 File Offset: 0x00A315D4
		[RequiredMember]
		public string ParticipantKey { get; set; }

		// Token: 0x17004965 RID: 18789
		// (get) Token: 0x06024022 RID: 147490 RVA: 0x00A333DD File Offset: 0x00A315DD
		// (set) Token: 0x06024023 RID: 147491 RVA: 0x00A333E5 File Offset: 0x00A315E5
		public int? MovedRoleId { get; set; }

		// Token: 0x17004966 RID: 18790
		// (get) Token: 0x06024024 RID: 147492 RVA: 0x00A333EE File Offset: 0x00A315EE
		// (set) Token: 0x06024025 RID: 147493 RVA: 0x00A333F6 File Offset: 0x00A315F6
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		public Func<IWuWaGoGridRelocationContext, IWuWaGoWorldMoveTarget> CreateWorldMoveTarget { [return: Nullable(new byte[]
		{
			2,
			1,
			2
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			2
		})] set; }

		// Token: 0x17004967 RID: 18791
		// (get) Token: 0x06024026 RID: 147494 RVA: 0x00A333FF File Offset: 0x00A315FF
		// (set) Token: 0x06024027 RID: 147495 RVA: 0x00A33407 File Offset: 0x00A31607
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<IWuWaGoGridRelocationContext> BeforeGridMove { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17004968 RID: 18792
		// (get) Token: 0x06024028 RID: 147496 RVA: 0x00A33410 File Offset: 0x00A31610
		// (set) Token: 0x06024029 RID: 147497 RVA: 0x00A33418 File Offset: 0x00A31618
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<IWuWaGoGridRelocationContext> CommitGridMove { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17004969 RID: 18793
		// (get) Token: 0x0602402A RID: 147498 RVA: 0x00A33421 File Offset: 0x00A31621
		// (set) Token: 0x0602402B RID: 147499 RVA: 0x00A33429 File Offset: 0x00A31629
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<IWuWaGoGridRelocationContext, UniTask> AfterGridMove { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x0602402C RID: 147500 RVA: 0x00A33432 File Offset: 0x00A31632
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public WuWaGoGridMoveParticipant()
		{
		}
	}
}
