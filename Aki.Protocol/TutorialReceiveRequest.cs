using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001476 RID: 5238
	[NetMessage(EMessageId.TutorialReceiveRequest)]
	public sealed class TutorialReceiveRequest : IMessage<TutorialReceiveRequest>, IMessage, IEquatable<TutorialReceiveRequest>, IDeepCloneable<TutorialReceiveRequest>, IBufferMessage
	{
		// Token: 0x0601BBA0 RID: 113568 RVA: 0x004030B5 File Offset: 0x004012B5
		[NullableContext(1)]
		public static TutorialReceiveRequest Create()
		{
			return new TutorialReceiveRequest();
		}

		// Token: 0x17005D7E RID: 23934
		// (get) Token: 0x0601BBA1 RID: 113569 RVA: 0x004030BC File Offset: 0x004012BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D7F RID: 23935
		// (get) Token: 0x0601BBA2 RID: 113570 RVA: 0x004030BF File Offset: 0x004012BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TutorialReceiveRequest.Descriptor;
			}
		}

		// Token: 0x0601BBA3 RID: 113571 RVA: 0x004030C6 File Offset: 0x004012C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialReceiveRequest()
		{
		}

		// Token: 0x0601BBA4 RID: 113572 RVA: 0x004030CE File Offset: 0x004012CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialReceiveRequest(TutorialReceiveRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BBA5 RID: 113573 RVA: 0x004030F3 File Offset: 0x004012F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialReceiveRequest Clone()
		{
			return new TutorialReceiveRequest(this);
		}

		// Token: 0x17005D80 RID: 23936
		// (get) Token: 0x0601BBA6 RID: 113574 RVA: 0x004030FB File Offset: 0x004012FB
		// (set) Token: 0x0601BBA7 RID: 113575 RVA: 0x00403103 File Offset: 0x00401303
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

		// Token: 0x0601BBA8 RID: 113576 RVA: 0x0040310C File Offset: 0x0040130C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TutorialReceiveRequest);
		}

		// Token: 0x0601BBA9 RID: 113577 RVA: 0x0040311A File Offset: 0x0040131A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TutorialReceiveRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BBAA RID: 113578 RVA: 0x00403148 File Offset: 0x00401348
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

		// Token: 0x0601BBAB RID: 113579 RVA: 0x00403187 File Offset: 0x00401387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BBAC RID: 113580 RVA: 0x00403194 File Offset: 0x00401394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BBAD RID: 113581 RVA: 0x0040319D File Offset: 0x0040139D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BBAE RID: 113582 RVA: 0x004031D0 File Offset: 0x004013D0
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

		// Token: 0x0601BBAF RID: 113583 RVA: 0x0040320E File Offset: 0x0040140E
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

		// Token: 0x0601BBB0 RID: 113584 RVA: 0x0040323F File Offset: 0x0040143F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BBB1 RID: 113585 RVA: 0x00403248 File Offset: 0x00401448
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009FAC RID: 40876
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FAD RID: 40877
		public const int IdFieldNumber = 14;

		// Token: 0x04009FAE RID: 40878
		private int id_;
	}
}
