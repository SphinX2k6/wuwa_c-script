using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B55 RID: 2901
	[NetMessage(EMessageId.NewTrialRoleGetNightmarePhantomInstInfoRequest)]
	public sealed class NewTrialRoleGetNightmarePhantomInstInfoRequest : IMessage<NewTrialRoleGetNightmarePhantomInstInfoRequest>, IMessage, IEquatable<NewTrialRoleGetNightmarePhantomInstInfoRequest>, IDeepCloneable<NewTrialRoleGetNightmarePhantomInstInfoRequest>, IBufferMessage
	{
		// Token: 0x0600FB7B RID: 64379 RVA: 0x0024A42B File Offset: 0x0024862B
		[NullableContext(1)]
		public static NewTrialRoleGetNightmarePhantomInstInfoRequest Create()
		{
			return new NewTrialRoleGetNightmarePhantomInstInfoRequest();
		}

		// Token: 0x17003344 RID: 13124
		// (get) Token: 0x0600FB7C RID: 64380 RVA: 0x0024A432 File Offset: 0x00248632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003345 RID: 13125
		// (get) Token: 0x0600FB7D RID: 64381 RVA: 0x0024A435 File Offset: 0x00248635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTrialRoleGetNightmarePhantomInstInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600FB7E RID: 64382 RVA: 0x0024A43C File Offset: 0x0024863C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTrialRoleGetNightmarePhantomInstInfoRequest()
		{
		}

		// Token: 0x0600FB7F RID: 64383 RVA: 0x0024A444 File Offset: 0x00248644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTrialRoleGetNightmarePhantomInstInfoRequest(NewTrialRoleGetNightmarePhantomInstInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FB80 RID: 64384 RVA: 0x0024A45D File Offset: 0x0024865D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTrialRoleGetNightmarePhantomInstInfoRequest Clone()
		{
			return new NewTrialRoleGetNightmarePhantomInstInfoRequest(this);
		}

		// Token: 0x0600FB81 RID: 64385 RVA: 0x0024A465 File Offset: 0x00248665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTrialRoleGetNightmarePhantomInstInfoRequest);
		}

		// Token: 0x0600FB82 RID: 64386 RVA: 0x0024A473 File Offset: 0x00248673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTrialRoleGetNightmarePhantomInstInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600FB83 RID: 64387 RVA: 0x0024A494 File Offset: 0x00248694
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

		// Token: 0x0600FB84 RID: 64388 RVA: 0x0024A4BA File Offset: 0x002486BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FB85 RID: 64389 RVA: 0x0024A4C7 File Offset: 0x002486C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FB86 RID: 64390 RVA: 0x0024A4D0 File Offset: 0x002486D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FB87 RID: 64391 RVA: 0x0024A4E8 File Offset: 0x002486E8
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

		// Token: 0x0600FB88 RID: 64392 RVA: 0x0024A50E File Offset: 0x0024870E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTrialRoleGetNightmarePhantomInstInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FB89 RID: 64393 RVA: 0x0024A52B File Offset: 0x0024872B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FB8A RID: 64394 RVA: 0x0024A534 File Offset: 0x00248734
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

		// Token: 0x04006485 RID: 25733
		private UnknownFieldSet _unknownFields;
	}
}
