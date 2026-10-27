using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CD0 RID: 3280
	public sealed class PhantomFetterGroupInfo : IMessage<PhantomFetterGroupInfo>, IMessage, IEquatable<PhantomFetterGroupInfo>, IDeepCloneable<PhantomFetterGroupInfo>, IBufferMessage
	{
		// Token: 0x06011C0E RID: 72718 RVA: 0x00299061 File Offset: 0x00297261
		[NullableContext(1)]
		public static PhantomFetterGroupInfo Create()
		{
			return new PhantomFetterGroupInfo();
		}

		// Token: 0x17003AD0 RID: 15056
		// (get) Token: 0x06011C0F RID: 72719 RVA: 0x00299068 File Offset: 0x00297268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomFetterGroupInfo> Parser
		{
			get
			{
				return PhantomFetterGroupInfo._parser;
			}
		}

		// Token: 0x17003AD1 RID: 15057
		// (get) Token: 0x06011C10 RID: 72720 RVA: 0x0029906F File Offset: 0x0029726F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AD2 RID: 15058
		// (get) Token: 0x06011C11 RID: 72721 RVA: 0x00299072 File Offset: 0x00297272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomFetterGroupInfo.Descriptor;
			}
		}

		// Token: 0x06011C12 RID: 72722 RVA: 0x00299079 File Offset: 0x00297279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFetterGroupInfo()
		{
		}

		// Token: 0x06011C13 RID: 72723 RVA: 0x00299081 File Offset: 0x00297281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFetterGroupInfo(PhantomFetterGroupInfo other) : this()
		{
			this.phantomFetterGroupId_ = other.phantomFetterGroupId_;
			this.countNeed_ = other.countNeed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011C14 RID: 72724 RVA: 0x002990B2 File Offset: 0x002972B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomFetterGroupInfo Clone()
		{
			return new PhantomFetterGroupInfo(this);
		}

		// Token: 0x17003AD3 RID: 15059
		// (get) Token: 0x06011C15 RID: 72725 RVA: 0x002990BA File Offset: 0x002972BA
		// (set) Token: 0x06011C16 RID: 72726 RVA: 0x002990C2 File Offset: 0x002972C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomFetterGroupId
		{
			get
			{
				return this.phantomFetterGroupId_;
			}
			set
			{
				this.phantomFetterGroupId_ = value;
			}
		}

		// Token: 0x17003AD4 RID: 15060
		// (get) Token: 0x06011C17 RID: 72727 RVA: 0x002990CB File Offset: 0x002972CB
		// (set) Token: 0x06011C18 RID: 72728 RVA: 0x002990D3 File Offset: 0x002972D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CountNeed
		{
			get
			{
				return this.countNeed_;
			}
			set
			{
				this.countNeed_ = value;
			}
		}

		// Token: 0x06011C19 RID: 72729 RVA: 0x002990DC File Offset: 0x002972DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomFetterGroupInfo);
		}

		// Token: 0x06011C1A RID: 72730 RVA: 0x002990EA File Offset: 0x002972EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomFetterGroupInfo other)
		{
			return other != null && (other == this || (this.PhantomFetterGroupId == other.PhantomFetterGroupId && this.CountNeed == other.CountNeed && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011C1B RID: 72731 RVA: 0x00299128 File Offset: 0x00297328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PhantomFetterGroupId != 0)
			{
				num ^= this.PhantomFetterGroupId.GetHashCode();
			}
			if (this.CountNeed != 0)
			{
				num ^= this.CountNeed.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011C1C RID: 72732 RVA: 0x00299180 File Offset: 0x00297380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011C1D RID: 72733 RVA: 0x0029918D File Offset: 0x0029738D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011C1E RID: 72734 RVA: 0x00299198 File Offset: 0x00297398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PhantomFetterGroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PhantomFetterGroupId);
			}
			if (this.CountNeed != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CountNeed);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011C1F RID: 72735 RVA: 0x002991F0 File Offset: 0x002973F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PhantomFetterGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomFetterGroupId);
			}
			if (this.CountNeed != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CountNeed);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011C20 RID: 72736 RVA: 0x00299248 File Offset: 0x00297448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomFetterGroupInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PhantomFetterGroupId != 0)
			{
				this.PhantomFetterGroupId = other.PhantomFetterGroupId;
			}
			if (other.CountNeed != 0)
			{
				this.CountNeed = other.CountNeed;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011C21 RID: 72737 RVA: 0x00299298 File Offset: 0x00297498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011C22 RID: 72738 RVA: 0x002992A4 File Offset: 0x002974A4
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CountNeed = input.ReadInt32();
					}
				}
				else
				{
					this.PhantomFetterGroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006F8C RID: 28556
		private static readonly MessageParser<PhantomFetterGroupInfo> _parser = new MessageParser<PhantomFetterGroupInfo>(() => new PhantomFetterGroupInfo());

		// Token: 0x04006F8D RID: 28557
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F8E RID: 28558
		public const int PhantomFetterGroupIdFieldNumber = 1;

		// Token: 0x04006F8F RID: 28559
		private int phantomFetterGroupId_;

		// Token: 0x04006F90 RID: 28560
		public const int CountNeedFieldNumber = 2;

		// Token: 0x04006F91 RID: 28561
		private int countNeed_;
	}
}
