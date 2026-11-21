using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014E9 RID: 5353
	[NetMessage(EMessageId.TutorialReceiveRequest)]
	public sealed class TutorialReceiveRequest : IMessage<TutorialReceiveRequest>, IMessage, IEquatable<TutorialReceiveRequest>, IDeepCloneable<TutorialReceiveRequest>, IBufferMessage
	{
		// Token: 0x0601C62B RID: 116267 RVA: 0x0041E37D File Offset: 0x0041C57D
		[NullableContext(1)]
		public static TutorialReceiveRequest Create()
		{
			return new TutorialReceiveRequest();
		}

		// Token: 0x17006013 RID: 24595
		// (get) Token: 0x0601C62C RID: 116268 RVA: 0x0041E384 File Offset: 0x0041C584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006014 RID: 24596
		// (get) Token: 0x0601C62D RID: 116269 RVA: 0x0041E387 File Offset: 0x0041C587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TutorialReceiveRequest.Descriptor;
			}
		}

		// Token: 0x0601C62E RID: 116270 RVA: 0x0041E38E File Offset: 0x0041C58E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialReceiveRequest()
		{
		}

		// Token: 0x0601C62F RID: 116271 RVA: 0x0041E396 File Offset: 0x0041C596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialReceiveRequest(TutorialReceiveRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C630 RID: 116272 RVA: 0x0041E3BB File Offset: 0x0041C5BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialReceiveRequest Clone()
		{
			return new TutorialReceiveRequest(this);
		}

		// Token: 0x17006015 RID: 24597
		// (get) Token: 0x0601C631 RID: 116273 RVA: 0x0041E3C3 File Offset: 0x0041C5C3
		// (set) Token: 0x0601C632 RID: 116274 RVA: 0x0041E3CB File Offset: 0x0041C5CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0601C633 RID: 116275 RVA: 0x0041E3D4 File Offset: 0x0041C5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TutorialReceiveRequest);
		}

		// Token: 0x0601C634 RID: 116276 RVA: 0x0041E3E2 File Offset: 0x0041C5E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TutorialReceiveRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C635 RID: 116277 RVA: 0x0041E410 File Offset: 0x0041C610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C636 RID: 116278 RVA: 0x0041E44F File Offset: 0x0041C64F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C637 RID: 116279 RVA: 0x0041E45C File Offset: 0x0041C65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C638 RID: 116280 RVA: 0x0041E465 File Offset: 0x0041C665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C639 RID: 116281 RVA: 0x0041E498 File Offset: 0x0041C698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C63A RID: 116282 RVA: 0x0041E4D6 File Offset: 0x0041C6D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TutorialReceiveRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C63B RID: 116283 RVA: 0x0041E507 File Offset: 0x0041C707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C63C RID: 116284 RVA: 0x0041E510 File Offset: 0x0041C710
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A3F3 RID: 41971
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3F4 RID: 41972
		public const int IdFieldNumber = 1;

		// Token: 0x0400A3F5 RID: 41973
		private int id_;
	}
}
