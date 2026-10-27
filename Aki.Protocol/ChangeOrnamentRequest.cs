using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000253 RID: 595
	[NetMessage(EMessageId.ChangeOrnamentRequest)]
	public sealed class ChangeOrnamentRequest : IMessage<ChangeOrnamentRequest>, IMessage, IEquatable<ChangeOrnamentRequest>, IDeepCloneable<ChangeOrnamentRequest>, IBufferMessage
	{
		// Token: 0x06003F59 RID: 16217 RVA: 0x0009BE64 File Offset: 0x0009A064
		[NullableContext(1)]
		public static ChangeOrnamentRequest Create()
		{
			return new ChangeOrnamentRequest();
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06003F5A RID: 16218 RVA: 0x0009BE6B File Offset: 0x0009A06B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06003F5B RID: 16219 RVA: 0x0009BE6E File Offset: 0x0009A06E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeOrnamentRequest.Descriptor;
			}
		}

		// Token: 0x06003F5C RID: 16220 RVA: 0x0009BE75 File Offset: 0x0009A075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeOrnamentRequest()
		{
		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x0009BE7D File Offset: 0x0009A07D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeOrnamentRequest(ChangeOrnamentRequest other) : this()
		{
			this.roleSkinId_ = other.roleSkinId_;
			this.ornamentId_ = other.ornamentId_;
			this.isDress_ = other.isDress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F5E RID: 16222 RVA: 0x0009BEBA File Offset: 0x0009A0BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeOrnamentRequest Clone()
		{
			return new ChangeOrnamentRequest(this);
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06003F5F RID: 16223 RVA: 0x0009BEC2 File Offset: 0x0009A0C2
		// (set) Token: 0x06003F60 RID: 16224 RVA: 0x0009BECA File Offset: 0x0009A0CA
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

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06003F61 RID: 16225 RVA: 0x0009BED3 File Offset: 0x0009A0D3
		// (set) Token: 0x06003F62 RID: 16226 RVA: 0x0009BEDB File Offset: 0x0009A0DB
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

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06003F63 RID: 16227 RVA: 0x0009BEE4 File Offset: 0x0009A0E4
		// (set) Token: 0x06003F64 RID: 16228 RVA: 0x0009BEEC File Offset: 0x0009A0EC
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

		// Token: 0x06003F65 RID: 16229 RVA: 0x0009BEF5 File Offset: 0x0009A0F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeOrnamentRequest);
		}

		// Token: 0x06003F66 RID: 16230 RVA: 0x0009BF04 File Offset: 0x0009A104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeOrnamentRequest other)
		{
			return other != null && (other == this || (this.RoleSkinId == other.RoleSkinId && this.OrnamentId == other.OrnamentId && this.IsDress == other.IsDress && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003F67 RID: 16231 RVA: 0x0009BF60 File Offset: 0x0009A160
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

		// Token: 0x06003F68 RID: 16232 RVA: 0x0009BFD1 File Offset: 0x0009A1D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003F69 RID: 16233 RVA: 0x0009BFDE File Offset: 0x0009A1DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F6A RID: 16234 RVA: 0x0009BFE8 File Offset: 0x0009A1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleSkinId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RoleSkinId);
			}
			if (this.OrnamentId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.OrnamentId);
			}
			if (this.IsDress)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsDress);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F6B RID: 16235 RVA: 0x0009C060 File Offset: 0x0009A260
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

		// Token: 0x06003F6C RID: 16236 RVA: 0x0009C0C4 File Offset: 0x0009A2C4
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

		// Token: 0x06003F6D RID: 16237 RVA: 0x0009C128 File Offset: 0x0009A328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F6E RID: 16238 RVA: 0x0009C134 File Offset: 0x0009A334
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
					if (num != 88U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.RoleSkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002D19 RID: 11545
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D1A RID: 11546
		public const int RoleSkinIdFieldNumber = 6;

		// Token: 0x04002D1B RID: 11547
		private int roleSkinId_;

		// Token: 0x04002D1C RID: 11548
		public const int OrnamentIdFieldNumber = 11;

		// Token: 0x04002D1D RID: 11549
		private int ornamentId_;

		// Token: 0x04002D1E RID: 11550
		public const int IsDressFieldNumber = 14;

		// Token: 0x04002D1F RID: 11551
		private bool isDress_;
	}
}
