using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F28 RID: 3880
	[NetMessage(EMessageId.RhythmChangePartnerRoleRequest)]
	public sealed class RhythmChangePartnerRoleRequest : IMessage<RhythmChangePartnerRoleRequest>, IMessage, IEquatable<RhythmChangePartnerRoleRequest>, IDeepCloneable<RhythmChangePartnerRoleRequest>, IBufferMessage
	{
		// Token: 0x06014CB1 RID: 85169 RVA: 0x00305065 File Offset: 0x00303265
		[NullableContext(1)]
		public static RhythmChangePartnerRoleRequest Create()
		{
			return new RhythmChangePartnerRoleRequest();
		}

		// Token: 0x1700452A RID: 17706
		// (get) Token: 0x06014CB2 RID: 85170 RVA: 0x0030506C File Offset: 0x0030326C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700452B RID: 17707
		// (get) Token: 0x06014CB3 RID: 85171 RVA: 0x0030506F File Offset: 0x0030326F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmChangePartnerRoleRequest.Descriptor;
			}
		}

		// Token: 0x06014CB4 RID: 85172 RVA: 0x00305076 File Offset: 0x00303276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmChangePartnerRoleRequest()
		{
		}

		// Token: 0x06014CB5 RID: 85173 RVA: 0x0030507E File Offset: 0x0030327E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmChangePartnerRoleRequest(RhythmChangePartnerRoleRequest other) : this()
		{
			this.rhythmRoleId_ = other.rhythmRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014CB6 RID: 85174 RVA: 0x003050A3 File Offset: 0x003032A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmChangePartnerRoleRequest Clone()
		{
			return new RhythmChangePartnerRoleRequest(this);
		}

		// Token: 0x1700452C RID: 17708
		// (get) Token: 0x06014CB7 RID: 85175 RVA: 0x003050AB File Offset: 0x003032AB
		// (set) Token: 0x06014CB8 RID: 85176 RVA: 0x003050B3 File Offset: 0x003032B3
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

		// Token: 0x06014CB9 RID: 85177 RVA: 0x003050BC File Offset: 0x003032BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmChangePartnerRoleRequest);
		}

		// Token: 0x06014CBA RID: 85178 RVA: 0x003050CA File Offset: 0x003032CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmChangePartnerRoleRequest other)
		{
			return other != null && (other == this || (this.RhythmRoleId == other.RhythmRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014CBB RID: 85179 RVA: 0x003050F8 File Offset: 0x003032F8
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

		// Token: 0x06014CBC RID: 85180 RVA: 0x00305137 File Offset: 0x00303337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014CBD RID: 85181 RVA: 0x00305144 File Offset: 0x00303344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014CBE RID: 85182 RVA: 0x0030514D File Offset: 0x0030334D
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

		// Token: 0x06014CBF RID: 85183 RVA: 0x00305180 File Offset: 0x00303380
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

		// Token: 0x06014CC0 RID: 85184 RVA: 0x003051BE File Offset: 0x003033BE
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

		// Token: 0x06014CC1 RID: 85185 RVA: 0x003051EF File Offset: 0x003033EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014CC2 RID: 85186 RVA: 0x003051F8 File Offset: 0x003033F8
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

		// Token: 0x04007DFD RID: 32253
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007DFE RID: 32254
		public const int RhythmRoleIdFieldNumber = 6;

		// Token: 0x04007DFF RID: 32255
		private int rhythmRoleId_;
	}
}
