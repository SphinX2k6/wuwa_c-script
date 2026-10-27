using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000176 RID: 374
	[NetMessage(EMessageId.BattlePassTaskRequest)]
	public sealed class BattlePassTaskRequest : IMessage<BattlePassTaskRequest>, IMessage, IEquatable<BattlePassTaskRequest>, IDeepCloneable<BattlePassTaskRequest>, IBufferMessage
	{
		// Token: 0x06002DC1 RID: 11713 RVA: 0x00076331 File Offset: 0x00074531
		[NullableContext(1)]
		public static BattlePassTaskRequest Create()
		{
			return new BattlePassTaskRequest();
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06002DC2 RID: 11714 RVA: 0x00076338 File Offset: 0x00074538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06002DC3 RID: 11715 RVA: 0x0007633B File Offset: 0x0007453B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassTaskRequest.Descriptor;
			}
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x00076342 File Offset: 0x00074542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskRequest()
		{
		}

		// Token: 0x06002DC5 RID: 11717 RVA: 0x0007634A File Offset: 0x0007454A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskRequest(BattlePassTaskRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002DC6 RID: 11718 RVA: 0x00076363 File Offset: 0x00074563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskRequest Clone()
		{
			return new BattlePassTaskRequest(this);
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x0007636B File Offset: 0x0007456B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassTaskRequest);
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x00076379 File Offset: 0x00074579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassTaskRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06002DC9 RID: 11721 RVA: 0x00076398 File Offset: 0x00074598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x000763BE File Offset: 0x000745BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002DCB RID: 11723 RVA: 0x000763CB File Offset: 0x000745CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x000763D4 File Offset: 0x000745D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x000763EC File Offset: 0x000745EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x00076412 File Offset: 0x00074612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassTaskRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x0007642F File Offset: 0x0007462F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002DD0 RID: 11728 RVA: 0x00076438 File Offset: 0x00074638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002848 RID: 10312
		private UnknownFieldSet _unknownFields;
	}
}
