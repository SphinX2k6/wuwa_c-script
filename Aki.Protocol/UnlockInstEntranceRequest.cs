using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200148A RID: 5258
	[NetMessage(EMessageId.UnlockInstEntranceRequest)]
	public sealed class UnlockInstEntranceRequest : IMessage<UnlockInstEntranceRequest>, IMessage, IEquatable<UnlockInstEntranceRequest>, IDeepCloneable<UnlockInstEntranceRequest>, IBufferMessage
	{
		// Token: 0x0601BD2B RID: 113963 RVA: 0x0040629B File Offset: 0x0040449B
		[NullableContext(1)]
		public static UnlockInstEntranceRequest Create()
		{
			return new UnlockInstEntranceRequest();
		}

		// Token: 0x17005DCD RID: 24013
		// (get) Token: 0x0601BD2C RID: 113964 RVA: 0x004062A2 File Offset: 0x004044A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DCE RID: 24014
		// (get) Token: 0x0601BD2D RID: 113965 RVA: 0x004062A5 File Offset: 0x004044A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockInstEntranceRequest.Descriptor;
			}
		}

		// Token: 0x0601BD2E RID: 113966 RVA: 0x004062AC File Offset: 0x004044AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockInstEntranceRequest()
		{
		}

		// Token: 0x0601BD2F RID: 113967 RVA: 0x004062B4 File Offset: 0x004044B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockInstEntranceRequest(UnlockInstEntranceRequest other) : this()
		{
			this.entranceId_ = other.entranceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BD30 RID: 113968 RVA: 0x004062D9 File Offset: 0x004044D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockInstEntranceRequest Clone()
		{
			return new UnlockInstEntranceRequest(this);
		}

		// Token: 0x17005DCF RID: 24015
		// (get) Token: 0x0601BD31 RID: 113969 RVA: 0x004062E1 File Offset: 0x004044E1
		// (set) Token: 0x0601BD32 RID: 113970 RVA: 0x004062E9 File Offset: 0x004044E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntranceId
		{
			get
			{
				return this.entranceId_;
			}
			set
			{
				this.entranceId_ = value;
			}
		}

		// Token: 0x0601BD33 RID: 113971 RVA: 0x004062F2 File Offset: 0x004044F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockInstEntranceRequest);
		}

		// Token: 0x0601BD34 RID: 113972 RVA: 0x00406300 File Offset: 0x00404500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockInstEntranceRequest other)
		{
			return other != null && (other == this || (this.EntranceId == other.EntranceId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BD35 RID: 113973 RVA: 0x00406330 File Offset: 0x00404530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntranceId != 0)
			{
				num ^= this.EntranceId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BD36 RID: 113974 RVA: 0x0040636F File Offset: 0x0040456F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BD37 RID: 113975 RVA: 0x0040637C File Offset: 0x0040457C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BD38 RID: 113976 RVA: 0x00406385 File Offset: 0x00404585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntranceId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.EntranceId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BD39 RID: 113977 RVA: 0x004063B8 File Offset: 0x004045B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntranceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntranceId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BD3A RID: 113978 RVA: 0x004063F6 File Offset: 0x004045F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockInstEntranceRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntranceId != 0)
			{
				this.EntranceId = other.EntranceId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BD3B RID: 113979 RVA: 0x00406427 File Offset: 0x00404627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BD3C RID: 113980 RVA: 0x00406430 File Offset: 0x00404630
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntranceId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A013 RID: 40979
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A014 RID: 40980
		public const int EntranceIdFieldNumber = 13;

		// Token: 0x0400A015 RID: 40981
		private int entranceId_;
	}
}
