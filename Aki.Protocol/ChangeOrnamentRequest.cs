using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000258 RID: 600
	[NetMessage(EMessageId.ChangeOrnamentRequest)]
	public sealed class ChangeOrnamentRequest : IMessage<ChangeOrnamentRequest>, IMessage, IEquatable<ChangeOrnamentRequest>, IDeepCloneable<ChangeOrnamentRequest>, IBufferMessage
	{
		// Token: 0x06003FFE RID: 16382 RVA: 0x0009DA88 File Offset: 0x0009BC88
		[NullableContext(1)]
		public static ChangeOrnamentRequest Create()
		{
			return new ChangeOrnamentRequest();
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06003FFF RID: 16383 RVA: 0x0009DA8F File Offset: 0x0009BC8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06004000 RID: 16384 RVA: 0x0009DA92 File Offset: 0x0009BC92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeOrnamentRequest.Descriptor;
			}
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x0009DA99 File Offset: 0x0009BC99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeOrnamentRequest()
		{
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x0009DAA1 File Offset: 0x0009BCA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeOrnamentRequest(ChangeOrnamentRequest other) : this()
		{
			this.roleSkinId_ = other.roleSkinId_;
			this.ornamentId_ = other.ornamentId_;
			this.isDress_ = other.isDress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004003 RID: 16387 RVA: 0x0009DADE File Offset: 0x0009BCDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeOrnamentRequest Clone()
		{
			return new ChangeOrnamentRequest(this);
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06004004 RID: 16388 RVA: 0x0009DAE6 File Offset: 0x0009BCE6
		// (set) Token: 0x06004005 RID: 16389 RVA: 0x0009DAEE File Offset: 0x0009BCEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleSkinId
		{
			get
			{
				return this.roleSkinId_;
			}
			set
			{
				this.roleSkinId_ = value;
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06004006 RID: 16390 RVA: 0x0009DAF7 File Offset: 0x0009BCF7
		// (set) Token: 0x06004007 RID: 16391 RVA: 0x0009DAFF File Offset: 0x0009BCFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OrnamentId
		{
			get
			{
				return this.ornamentId_;
			}
			set
			{
				this.ornamentId_ = value;
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06004008 RID: 16392 RVA: 0x0009DB08 File Offset: 0x0009BD08
		// (set) Token: 0x06004009 RID: 16393 RVA: 0x0009DB10 File Offset: 0x0009BD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsDress
		{
			get
			{
				return this.isDress_;
			}
			set
			{
				this.isDress_ = value;
			}
		}

		// Token: 0x0600400A RID: 16394 RVA: 0x0009DB19 File Offset: 0x0009BD19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeOrnamentRequest);
		}

		// Token: 0x0600400B RID: 16395 RVA: 0x0009DB28 File Offset: 0x0009BD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeOrnamentRequest other)
		{
			return other != null && (other == this || (this.RoleSkinId == other.RoleSkinId && this.OrnamentId == other.OrnamentId && this.IsDress == other.IsDress && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600400C RID: 16396 RVA: 0x0009DB84 File Offset: 0x0009BD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleSkinId != 0)
			{
				num ^= this.RoleSkinId.GetHashCode();
			}
			if (this.OrnamentId != 0)
			{
				num ^= this.OrnamentId.GetHashCode();
			}
			if (this.IsDress)
			{
				num ^= this.IsDress.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600400D RID: 16397 RVA: 0x0009DBF5 File Offset: 0x0009BDF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600400E RID: 16398 RVA: 0x0009DC02 File Offset: 0x0009BE02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600400F RID: 16399 RVA: 0x0009DC0C File Offset: 0x0009BE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OrnamentId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.OrnamentId);
			}
			if (this.IsDress)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsDress);
			}
			if (this.RoleSkinId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.RoleSkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004010 RID: 16400 RVA: 0x0009DC84 File Offset: 0x0009BE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleSkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleSkinId);
			}
			if (this.OrnamentId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OrnamentId);
			}
			if (this.IsDress)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004011 RID: 16401 RVA: 0x0009DCE8 File Offset: 0x0009BEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeOrnamentRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleSkinId != 0)
			{
				this.RoleSkinId = other.RoleSkinId;
			}
			if (other.OrnamentId != 0)
			{
				this.OrnamentId = other.OrnamentId;
			}
			if (other.IsDress)
			{
				this.IsDress = other.IsDress;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004012 RID: 16402 RVA: 0x0009DD4C File Offset: 0x0009BF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004013 RID: 16403 RVA: 0x0009DD58 File Offset: 0x0009BF58
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
				if (num != 32U)
				{
					if (num != 80U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RoleSkinId = input.ReadInt32();
						}
					}
					else
					{
						this.IsDress = input.ReadBool();
					}
				}
				else
				{
					this.OrnamentId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002D9B RID: 11675
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D9C RID: 11676
		public const int RoleSkinIdFieldNumber = 14;

		// Token: 0x04002D9D RID: 11677
		private int roleSkinId_;

		// Token: 0x04002D9E RID: 11678
		public const int OrnamentIdFieldNumber = 4;

		// Token: 0x04002D9F RID: 11679
		private int ornamentId_;

		// Token: 0x04002DA0 RID: 11680
		public const int IsDressFieldNumber = 10;

		// Token: 0x04002DA1 RID: 11681
		private bool isDress_;
	}
}
