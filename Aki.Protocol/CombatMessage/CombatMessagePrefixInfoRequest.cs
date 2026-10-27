using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x02001685 RID: 5765
	[NetMessage(EMessageId.CombatMessagePrefixInfoRequest)]
	public sealed class CombatMessagePrefixInfoRequest : IMessage<CombatMessagePrefixInfoRequest>, IMessage, IEquatable<CombatMessagePrefixInfoRequest>, IDeepCloneable<CombatMessagePrefixInfoRequest>, IBufferMessage
	{
		// Token: 0x0601CBF3 RID: 117747 RVA: 0x0042609D File Offset: 0x0042429D
		[NullableContext(1)]
		public static CombatMessagePrefixInfoRequest Create()
		{
			return new CombatMessagePrefixInfoRequest();
		}

		// Token: 0x170060DE RID: 24798
		// (get) Token: 0x0601CBF4 RID: 117748 RVA: 0x004260A4 File Offset: 0x004242A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060DF RID: 24799
		// (get) Token: 0x0601CBF5 RID: 117749 RVA: 0x004260A7 File Offset: 0x004242A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatMessagePrefixInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601CBF6 RID: 117750 RVA: 0x004260AE File Offset: 0x004242AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMessagePrefixInfoRequest()
		{
		}

		// Token: 0x0601CBF7 RID: 117751 RVA: 0x004260C1 File Offset: 0x004242C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMessagePrefixInfoRequest(CombatMessagePrefixInfoRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CBF8 RID: 117752 RVA: 0x004260E6 File Offset: 0x004242E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMessagePrefixInfoRequest Clone()
		{
			return new CombatMessagePrefixInfoRequest(this);
		}

		// Token: 0x170060E0 RID: 24800
		// (get) Token: 0x0601CBF9 RID: 117753 RVA: 0x004260EE File Offset: 0x004242EE
		// (set) Token: 0x0601CBFA RID: 117754 RVA: 0x004260F6 File Offset: 0x004242F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0601CBFB RID: 117755 RVA: 0x00426109 File Offset: 0x00424309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatMessagePrefixInfoRequest);
		}

		// Token: 0x0601CBFC RID: 117756 RVA: 0x00426117 File Offset: 0x00424317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatMessagePrefixInfoRequest other)
		{
			return other != null && (other == this || (!(this.Id != other.Id) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CBFD RID: 117757 RVA: 0x0042614C File Offset: 0x0042434C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id.Length != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CBFE RID: 117758 RVA: 0x0042618D File Offset: 0x0042438D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CBFF RID: 117759 RVA: 0x0042619A File Offset: 0x0042439A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CC00 RID: 117760 RVA: 0x004261A3 File Offset: 0x004243A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CC01 RID: 117761 RVA: 0x004261DC File Offset: 0x004243DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CC02 RID: 117762 RVA: 0x0042621F File Offset: 0x0042441F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatMessagePrefixInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id.Length != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CC03 RID: 117763 RVA: 0x00426255 File Offset: 0x00424455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CC04 RID: 117764 RVA: 0x00426260 File Offset: 0x00424460
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadString();
				}
			}
		}

		// Token: 0x0400C211 RID: 49681
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C212 RID: 49682
		public const int IdFieldNumber = 10;

		// Token: 0x0400C213 RID: 49683
		private string id_ = "";
	}
}
