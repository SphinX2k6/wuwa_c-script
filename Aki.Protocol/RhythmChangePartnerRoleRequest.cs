using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F38 RID: 3896
	[NetMessage(EMessageId.RhythmChangePartnerRoleRequest)]
	public sealed class RhythmChangePartnerRoleRequest : IMessage<RhythmChangePartnerRoleRequest>, IMessage, IEquatable<RhythmChangePartnerRoleRequest>, IDeepCloneable<RhythmChangePartnerRoleRequest>, IBufferMessage
	{
		// Token: 0x06014D96 RID: 85398 RVA: 0x00306721 File Offset: 0x00304921
		[NullableContext(1)]
		public static RhythmChangePartnerRoleRequest Create()
		{
			return new RhythmChangePartnerRoleRequest();
		}

		// Token: 0x17004554 RID: 17748
		// (get) Token: 0x06014D97 RID: 85399 RVA: 0x00306728 File Offset: 0x00304928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004555 RID: 17749
		// (get) Token: 0x06014D98 RID: 85400 RVA: 0x0030672B File Offset: 0x0030492B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmChangePartnerRoleRequest.Descriptor;
			}
		}

		// Token: 0x06014D99 RID: 85401 RVA: 0x00306732 File Offset: 0x00304932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmChangePartnerRoleRequest()
		{
		}

		// Token: 0x06014D9A RID: 85402 RVA: 0x0030673A File Offset: 0x0030493A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmChangePartnerRoleRequest(RhythmChangePartnerRoleRequest other) : this()
		{
			this.rhythmRoleId_ = other.rhythmRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014D9B RID: 85403 RVA: 0x0030675F File Offset: 0x0030495F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmChangePartnerRoleRequest Clone()
		{
			return new RhythmChangePartnerRoleRequest(this);
		}

		// Token: 0x17004556 RID: 17750
		// (get) Token: 0x06014D9C RID: 85404 RVA: 0x00306767 File Offset: 0x00304967
		// (set) Token: 0x06014D9D RID: 85405 RVA: 0x0030676F File Offset: 0x0030496F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RhythmRoleId
		{
			get
			{
				return this.rhythmRoleId_;
			}
			set
			{
				this.rhythmRoleId_ = value;
			}
		}

		// Token: 0x06014D9E RID: 85406 RVA: 0x00306778 File Offset: 0x00304978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmChangePartnerRoleRequest);
		}

		// Token: 0x06014D9F RID: 85407 RVA: 0x00306786 File Offset: 0x00304986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmChangePartnerRoleRequest other)
		{
			return other != null && (other == this || (this.RhythmRoleId == other.RhythmRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014DA0 RID: 85408 RVA: 0x003067B4 File Offset: 0x003049B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RhythmRoleId != 0)
			{
				num ^= this.RhythmRoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014DA1 RID: 85409 RVA: 0x003067F3 File Offset: 0x003049F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014DA2 RID: 85410 RVA: 0x00306800 File Offset: 0x00304A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014DA3 RID: 85411 RVA: 0x00306809 File Offset: 0x00304A09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RhythmRoleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RhythmRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014DA4 RID: 85412 RVA: 0x0030683C File Offset: 0x00304A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RhythmRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RhythmRoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014DA5 RID: 85413 RVA: 0x0030687A File Offset: 0x00304A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmChangePartnerRoleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RhythmRoleId != 0)
			{
				this.RhythmRoleId = other.RhythmRoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014DA6 RID: 85414 RVA: 0x003068AB File Offset: 0x00304AAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014DA7 RID: 85415 RVA: 0x003068B4 File Offset: 0x00304AB4
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RhythmRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007DD3 RID: 32211
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007DD4 RID: 32212
		public const int RhythmRoleIdFieldNumber = 6;

		// Token: 0x04007DD5 RID: 32213
		private int rhythmRoleId_;
	}
}
