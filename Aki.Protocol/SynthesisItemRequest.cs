using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200130F RID: 4879
	[NetMessage(EMessageId.SynthesisItemRequest)]
	public sealed class SynthesisItemRequest : IMessage<SynthesisItemRequest>, IMessage, IEquatable<SynthesisItemRequest>, IDeepCloneable<SynthesisItemRequest>, IBufferMessage
	{
		// Token: 0x06019EDE RID: 106206 RVA: 0x003C45B2 File Offset: 0x003C27B2
		[NullableContext(1)]
		public static SynthesisItemRequest Create()
		{
			return new SynthesisItemRequest();
		}

		// Token: 0x1700576E RID: 22382
		// (get) Token: 0x06019EDF RID: 106207 RVA: 0x003C45B9 File Offset: 0x003C27B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700576F RID: 22383
		// (get) Token: 0x06019EE0 RID: 106208 RVA: 0x003C45BC File Offset: 0x003C27BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SynthesisItemRequest.Descriptor;
			}
		}

		// Token: 0x06019EE1 RID: 106209 RVA: 0x003C45C3 File Offset: 0x003C27C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisItemRequest()
		{
		}

		// Token: 0x06019EE2 RID: 106210 RVA: 0x003C45CC File Offset: 0x003C27CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisItemRequest(SynthesisItemRequest other) : this()
		{
			this.id_ = other.id_;
			this.roleId_ = other.roleId_;
			this.count_ = other.count_;
			this.interactEntityId_ = other.interactEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019EE3 RID: 106211 RVA: 0x003C4620 File Offset: 0x003C2820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisItemRequest Clone()
		{
			return new SynthesisItemRequest(this);
		}

		// Token: 0x17005770 RID: 22384
		// (get) Token: 0x06019EE4 RID: 106212 RVA: 0x003C4628 File Offset: 0x003C2828
		// (set) Token: 0x06019EE5 RID: 106213 RVA: 0x003C4630 File Offset: 0x003C2830
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

		// Token: 0x17005771 RID: 22385
		// (get) Token: 0x06019EE6 RID: 106214 RVA: 0x003C4639 File Offset: 0x003C2839
		// (set) Token: 0x06019EE7 RID: 106215 RVA: 0x003C4641 File Offset: 0x003C2841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17005772 RID: 22386
		// (get) Token: 0x06019EE8 RID: 106216 RVA: 0x003C464A File Offset: 0x003C284A
		// (set) Token: 0x06019EE9 RID: 106217 RVA: 0x003C4652 File Offset: 0x003C2852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x17005773 RID: 22387
		// (get) Token: 0x06019EEA RID: 106218 RVA: 0x003C465B File Offset: 0x003C285B
		// (set) Token: 0x06019EEB RID: 106219 RVA: 0x003C4663 File Offset: 0x003C2863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long InteractEntityId
		{
			get
			{
				return this.interactEntityId_;
			}
			set
			{
				this.interactEntityId_ = value;
			}
		}

		// Token: 0x06019EEC RID: 106220 RVA: 0x003C466C File Offset: 0x003C286C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SynthesisItemRequest);
		}

		// Token: 0x06019EED RID: 106221 RVA: 0x003C467C File Offset: 0x003C287C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SynthesisItemRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.RoleId == other.RoleId && this.Count == other.Count && this.InteractEntityId == other.InteractEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019EEE RID: 106222 RVA: 0x003C46E8 File Offset: 0x003C28E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.InteractEntityId != 0L)
			{
				num ^= this.InteractEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019EEF RID: 106223 RVA: 0x003C4772 File Offset: 0x003C2972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019EF0 RID: 106224 RVA: 0x003C477F File Offset: 0x003C297F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019EF1 RID: 106225 RVA: 0x003C4788 File Offset: 0x003C2988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Count != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Count);
			}
			if (this.InteractEntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.InteractEntityId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Id);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019EF2 RID: 106226 RVA: 0x003C481C File Offset: 0x003C2A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.InteractEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InteractEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019EF3 RID: 106227 RVA: 0x003C48A4 File Offset: 0x003C2AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SynthesisItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.InteractEntityId != 0L)
			{
				this.InteractEntityId = other.InteractEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019EF4 RID: 106228 RVA: 0x003C491C File Offset: 0x003C2B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019EF5 RID: 106229 RVA: 0x003C4928 File Offset: 0x003C2B28
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
				if (num <= 56U)
				{
					if (num == 32U)
					{
						this.Count = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.InteractEntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009787 RID: 38791
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009788 RID: 38792
		public const int IdFieldNumber = 8;

		// Token: 0x04009789 RID: 38793
		private int id_;

		// Token: 0x0400978A RID: 38794
		public const int RoleIdFieldNumber = 10;

		// Token: 0x0400978B RID: 38795
		private int roleId_;

		// Token: 0x0400978C RID: 38796
		public const int CountFieldNumber = 4;

		// Token: 0x0400978D RID: 38797
		private int count_;

		// Token: 0x0400978E RID: 38798
		public const int InteractEntityIdFieldNumber = 7;

		// Token: 0x0400978F RID: 38799
		private long interactEntityId_;
	}
}
