using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200037A RID: 890
	[NetMessage(EMessageId.DangoBrawlStartFightRequest)]
	public sealed class DangoBrawlStartFightRequest : IMessage<DangoBrawlStartFightRequest>, IMessage, IEquatable<DangoBrawlStartFightRequest>, IDeepCloneable<DangoBrawlStartFightRequest>, IBufferMessage
	{
		// Token: 0x06005852 RID: 22610 RVA: 0x000D76D5 File Offset: 0x000D58D5
		[NullableContext(1)]
		public static DangoBrawlStartFightRequest Create()
		{
			return new DangoBrawlStartFightRequest();
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x06005853 RID: 22611 RVA: 0x000D76DC File Offset: 0x000D58DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x06005854 RID: 22612 RVA: 0x000D76DF File Offset: 0x000D58DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlStartFightRequest.Descriptor;
			}
		}

		// Token: 0x06005855 RID: 22613 RVA: 0x000D76E6 File Offset: 0x000D58E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlStartFightRequest()
		{
		}

		// Token: 0x06005856 RID: 22614 RVA: 0x000D76EE File Offset: 0x000D58EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlStartFightRequest(DangoBrawlStartFightRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005857 RID: 22615 RVA: 0x000D7707 File Offset: 0x000D5907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlStartFightRequest Clone()
		{
			return new DangoBrawlStartFightRequest(this);
		}

		// Token: 0x06005858 RID: 22616 RVA: 0x000D770F File Offset: 0x000D590F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlStartFightRequest);
		}

		// Token: 0x06005859 RID: 22617 RVA: 0x000D771D File Offset: 0x000D591D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlStartFightRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600585A RID: 22618 RVA: 0x000D773C File Offset: 0x000D593C
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

		// Token: 0x0600585B RID: 22619 RVA: 0x000D7762 File Offset: 0x000D5962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600585C RID: 22620 RVA: 0x000D776F File Offset: 0x000D596F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600585D RID: 22621 RVA: 0x000D7778 File Offset: 0x000D5978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600585E RID: 22622 RVA: 0x000D7790 File Offset: 0x000D5990
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

		// Token: 0x0600585F RID: 22623 RVA: 0x000D77B6 File Offset: 0x000D59B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlStartFightRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005860 RID: 22624 RVA: 0x000D77D3 File Offset: 0x000D59D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005861 RID: 22625 RVA: 0x000D77DC File Offset: 0x000D59DC
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

		// Token: 0x0400350E RID: 13582
		private UnknownFieldSet _unknownFields;
	}
}
