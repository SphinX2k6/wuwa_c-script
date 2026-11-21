using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B44 RID: 2884
	[NetMessage(EMessageId.NewTrialRoleGetNightmarePhantomInstInfoRequest)]
	public sealed class NewTrialRoleGetNightmarePhantomInstInfoRequest : IMessage<NewTrialRoleGetNightmarePhantomInstInfoRequest>, IMessage, IEquatable<NewTrialRoleGetNightmarePhantomInstInfoRequest>, IDeepCloneable<NewTrialRoleGetNightmarePhantomInstInfoRequest>, IBufferMessage
	{
		// Token: 0x0600FA61 RID: 64097 RVA: 0x00248217 File Offset: 0x00246417
		[NullableContext(1)]
		public static NewTrialRoleGetNightmarePhantomInstInfoRequest Create()
		{
			return new NewTrialRoleGetNightmarePhantomInstInfoRequest();
		}

		// Token: 0x17003306 RID: 13062
		// (get) Token: 0x0600FA62 RID: 64098 RVA: 0x0024821E File Offset: 0x0024641E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003307 RID: 13063
		// (get) Token: 0x0600FA63 RID: 64099 RVA: 0x00248221 File Offset: 0x00246421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTrialRoleGetNightmarePhantomInstInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600FA64 RID: 64100 RVA: 0x00248228 File Offset: 0x00246428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTrialRoleGetNightmarePhantomInstInfoRequest()
		{
		}

		// Token: 0x0600FA65 RID: 64101 RVA: 0x00248230 File Offset: 0x00246430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTrialRoleGetNightmarePhantomInstInfoRequest(NewTrialRoleGetNightmarePhantomInstInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FA66 RID: 64102 RVA: 0x00248249 File Offset: 0x00246449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTrialRoleGetNightmarePhantomInstInfoRequest Clone()
		{
			return new NewTrialRoleGetNightmarePhantomInstInfoRequest(this);
		}

		// Token: 0x0600FA67 RID: 64103 RVA: 0x00248251 File Offset: 0x00246451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTrialRoleGetNightmarePhantomInstInfoRequest);
		}

		// Token: 0x0600FA68 RID: 64104 RVA: 0x0024825F File Offset: 0x0024645F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTrialRoleGetNightmarePhantomInstInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600FA69 RID: 64105 RVA: 0x00248280 File Offset: 0x00246480
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

		// Token: 0x0600FA6A RID: 64106 RVA: 0x002482A6 File Offset: 0x002464A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FA6B RID: 64107 RVA: 0x002482B3 File Offset: 0x002464B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FA6C RID: 64108 RVA: 0x002482BC File Offset: 0x002464BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FA6D RID: 64109 RVA: 0x002482D4 File Offset: 0x002464D4
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

		// Token: 0x0600FA6E RID: 64110 RVA: 0x002482FA File Offset: 0x002464FA
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

		// Token: 0x0600FA6F RID: 64111 RVA: 0x00248317 File Offset: 0x00246517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FA70 RID: 64112 RVA: 0x00248320 File Offset: 0x00246520
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

		// Token: 0x0400648E RID: 25742
		private UnknownFieldSet _unknownFields;
	}
}
