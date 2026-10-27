using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D02 RID: 3330
	[NetMessage(EMessageId.PhantomSettingRequest)]
	public sealed class PhantomSettingRequest : IMessage<PhantomSettingRequest>, IMessage, IEquatable<PhantomSettingRequest>, IDeepCloneable<PhantomSettingRequest>, IBufferMessage
	{
		// Token: 0x06012000 RID: 73728 RVA: 0x002A1AFF File Offset: 0x0029FCFF
		[NullableContext(1)]
		public static PhantomSettingRequest Create()
		{
			return new PhantomSettingRequest();
		}

		// Token: 0x17003BA5 RID: 15269
		// (get) Token: 0x06012001 RID: 73729 RVA: 0x002A1B06 File Offset: 0x0029FD06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BA6 RID: 15270
		// (get) Token: 0x06012002 RID: 73730 RVA: 0x002A1B09 File Offset: 0x0029FD09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomSettingRequest.Descriptor;
			}
		}

		// Token: 0x06012003 RID: 73731 RVA: 0x002A1B10 File Offset: 0x0029FD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingRequest()
		{
		}

		// Token: 0x06012004 RID: 73732 RVA: 0x002A1B18 File Offset: 0x0029FD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingRequest(PhantomSettingRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012005 RID: 73733 RVA: 0x002A1B31 File Offset: 0x0029FD31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingRequest Clone()
		{
			return new PhantomSettingRequest(this);
		}

		// Token: 0x06012006 RID: 73734 RVA: 0x002A1B39 File Offset: 0x0029FD39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomSettingRequest);
		}

		// Token: 0x06012007 RID: 73735 RVA: 0x002A1B47 File Offset: 0x0029FD47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomSettingRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012008 RID: 73736 RVA: 0x002A1B68 File Offset: 0x0029FD68
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

		// Token: 0x06012009 RID: 73737 RVA: 0x002A1B8E File Offset: 0x0029FD8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601200A RID: 73738 RVA: 0x002A1B9B File Offset: 0x0029FD9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601200B RID: 73739 RVA: 0x002A1BA4 File Offset: 0x0029FDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601200C RID: 73740 RVA: 0x002A1BBC File Offset: 0x0029FDBC
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

		// Token: 0x0601200D RID: 73741 RVA: 0x002A1BE2 File Offset: 0x0029FDE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomSettingRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601200E RID: 73742 RVA: 0x002A1BFF File Offset: 0x0029FDFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601200F RID: 73743 RVA: 0x002A1C08 File Offset: 0x0029FE08
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

		// Token: 0x040070C6 RID: 28870
		private UnknownFieldSet _unknownFields;
	}
}
