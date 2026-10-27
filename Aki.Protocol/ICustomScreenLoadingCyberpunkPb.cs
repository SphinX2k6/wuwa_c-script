using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007BE RID: 1982
	public sealed class ICustomScreenLoadingCyberpunkPb : IMessage<ICustomScreenLoadingCyberpunkPb>, IMessage, IEquatable<ICustomScreenLoadingCyberpunkPb>, IDeepCloneable<ICustomScreenLoadingCyberpunkPb>, IBufferMessage
	{
		// Token: 0x0600B257 RID: 45655 RVA: 0x001AB121 File Offset: 0x001A9321
		[NullableContext(1)]
		public static ICustomScreenLoadingCyberpunkPb Create()
		{
			return new ICustomScreenLoadingCyberpunkPb();
		}

		// Token: 0x170023F9 RID: 9209
		// (get) Token: 0x0600B258 RID: 45656 RVA: 0x001AB128 File Offset: 0x001A9328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023FA RID: 9210
		// (get) Token: 0x0600B259 RID: 45657 RVA: 0x001AB12B File Offset: 0x001A932B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ICustomScreenLoadingCyberpunkPb.Descriptor;
			}
		}

		// Token: 0x0600B25A RID: 45658 RVA: 0x001AB132 File Offset: 0x001A9332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenLoadingCyberpunkPb()
		{
		}

		// Token: 0x0600B25B RID: 45659 RVA: 0x001AB13A File Offset: 0x001A933A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenLoadingCyberpunkPb(ICustomScreenLoadingCyberpunkPb other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B25C RID: 45660 RVA: 0x001AB153 File Offset: 0x001A9353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenLoadingCyberpunkPb Clone()
		{
			return new ICustomScreenLoadingCyberpunkPb(this);
		}

		// Token: 0x0600B25D RID: 45661 RVA: 0x001AB15B File Offset: 0x001A935B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ICustomScreenLoadingCyberpunkPb);
		}

		// Token: 0x0600B25E RID: 45662 RVA: 0x001AB169 File Offset: 0x001A9369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ICustomScreenLoadingCyberpunkPb other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B25F RID: 45663 RVA: 0x001AB188 File Offset: 0x001A9388
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

		// Token: 0x0600B260 RID: 45664 RVA: 0x001AB1AE File Offset: 0x001A93AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B261 RID: 45665 RVA: 0x001AB1BB File Offset: 0x001A93BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B262 RID: 45666 RVA: 0x001AB1C4 File Offset: 0x001A93C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B263 RID: 45667 RVA: 0x001AB1DC File Offset: 0x001A93DC
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

		// Token: 0x0600B264 RID: 45668 RVA: 0x001AB202 File Offset: 0x001A9402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ICustomScreenLoadingCyberpunkPb other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B265 RID: 45669 RVA: 0x001AB21F File Offset: 0x001A941F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B266 RID: 45670 RVA: 0x001AB228 File Offset: 0x001A9428
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

		// Token: 0x04004FBE RID: 20414
		private UnknownFieldSet _unknownFields;
	}
}
