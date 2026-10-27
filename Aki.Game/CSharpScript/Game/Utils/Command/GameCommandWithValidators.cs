using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x02004579 RID: 17785
	[NullableContext(1)]
	[Nullable(0)]
	internal class GameCommandWithValidators<[Nullable(0)] T> : IGameCommand<T>, IGameCommandBase where T : ICommandType
	{
		// Token: 0x17007590 RID: 30096
		// (get) Token: 0x0602DE67 RID: 188007 RVA: 0x00A8DA8D File Offset: 0x00A8BC8D
		// (set) Token: 0x0602DE68 RID: 188008 RVA: 0x00A8DA95 File Offset: 0x00A8BC95
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<TCommandHandleParams<T>> Execute { [return: Nullable(new byte[]
		{
			2,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1
		})] set; }

		// Token: 0x17007591 RID: 30097
		// (get) Token: 0x0602DE69 RID: 188009 RVA: 0x00A8DA9E File Offset: 0x00A8BC9E
		// (set) Token: 0x0602DE6A RID: 188010 RVA: 0x00A8DAA6 File Offset: 0x00A8BCA6
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<TCommandHandleParams<T>> Undo { [return: Nullable(new byte[]
		{
			2,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1
		})] set; }

		// Token: 0x17007592 RID: 30098
		// (get) Token: 0x0602DE6B RID: 188011 RVA: 0x00A8DAAF File Offset: 0x00A8BCAF
		// (set) Token: 0x0602DE6C RID: 188012 RVA: 0x00A8DAB7 File Offset: 0x00A8BCB7
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public TCommandHandleParams<T> Params { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x0602DE6D RID: 188013 RVA: 0x00A8DAC0 File Offset: 0x00A8BCC0
		public void AddValidator(IValidator validator)
		{
			this.Validators.Add(validator);
		}

		// Token: 0x0602DE6E RID: 188014 RVA: 0x00A8DACF File Offset: 0x00A8BCCF
		public void RemoveValidator(IValidator validator)
		{
			this.Validators.Remove(validator);
		}

		// Token: 0x0401883B RID: 100411
		public HashSet<IValidator> Validators = new HashSet<IValidator>();
	}
}
