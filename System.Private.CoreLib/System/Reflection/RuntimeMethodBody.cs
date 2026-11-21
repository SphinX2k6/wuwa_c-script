using System;
using System.Collections.Generic;

namespace System.Reflection
{
	// Token: 0x0200070B RID: 1803
	internal sealed class RuntimeMethodBody : MethodBody
	{
		// Token: 0x0600773C RID: 30524 RVA: 0x0011BC84 File Offset: 0x00119E84
		internal RuntimeMethodBody(ExceptionHandlingClause[] clauses, LocalVariableInfo[] locals, byte[] il, bool init_locals, int sig_token, int max_stack)
		{
			this._exceptionHandlingClauses = clauses;
			this._localVariables = locals;
			this._IL = il;
			this._initLocals = init_locals;
			this._localSignatureMetadataToken = sig_token;
			this._maxStackSize = max_stack;
		}

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x0600773D RID: 30525 RVA: 0x0011BCB9 File Offset: 0x00119EB9
		public override int LocalSignatureMetadataToken
		{
			get
			{
				return this._localSignatureMetadataToken;
			}
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x0600773E RID: 30526 RVA: 0x0011BCC1 File Offset: 0x00119EC1
		public override IList<LocalVariableInfo> LocalVariables
		{
			get
			{
				return Array.AsReadOnly<LocalVariableInfo>(this._localVariables);
			}
		}

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x0600773F RID: 30527 RVA: 0x0011BCCE File Offset: 0x00119ECE
		public override int MaxStackSize
		{
			get
			{
				return this._maxStackSize;
			}
		}

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x06007740 RID: 30528 RVA: 0x0011BCD6 File Offset: 0x00119ED6
		public override bool InitLocals
		{
			get
			{
				return this._initLocals;
			}
		}

		// Token: 0x06007741 RID: 30529 RVA: 0x0011BCDE File Offset: 0x00119EDE
		public override byte[] GetILAsByteArray()
		{
			return this._IL;
		}

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x06007742 RID: 30530 RVA: 0x0011BCE6 File Offset: 0x00119EE6
		public override IList<ExceptionHandlingClause> ExceptionHandlingClauses
		{
			get
			{
				return Array.AsReadOnly<ExceptionHandlingClause>(this._exceptionHandlingClauses);
			}
		}

		// Token: 0x04001587 RID: 5511
		private byte[] _IL;

		// Token: 0x04001588 RID: 5512
		private ExceptionHandlingClause[] _exceptionHandlingClauses;

		// Token: 0x04001589 RID: 5513
		private LocalVariableInfo[] _localVariables;

		// Token: 0x0400158A RID: 5514
		private int _localSignatureMetadataToken;

		// Token: 0x0400158B RID: 5515
		private int _maxStackSize;

		// Token: 0x0400158C RID: 5516
		private bool _initLocals;
	}
}
