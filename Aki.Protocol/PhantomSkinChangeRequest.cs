using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CF7 RID: 3319
	[NetMessage(EMessageId.PhantomSkinChangeRequest)]
	public sealed class PhantomSkinChangeRequest : IMessage<PhantomSkinChangeRequest>, IMessage, IEquatable<PhantomSkinChangeRequest>, IDeepCloneable<PhantomSkinChangeRequest>, IBufferMessage
	{
		// Token: 0x06011F61 RID: 73569 RVA: 0x002A0A75 File Offset: 0x0029EC75
		[NullableContext(1)]
		public static PhantomSkinChangeRequest Create()
		{
			return new PhantomSkinChangeRequest();
		}

		// Token: 0x17003B81 RID: 15233
		// (get) Token: 0x06011F62 RID: 73570 RVA: 0x002A0A7C File Offset: 0x0029EC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B82 RID: 15234
		// (get) Token: 0x06011F63 RID: 73571 RVA: 0x002A0A7F File Offset: 0x0029EC7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomSkinChangeRequest.Descriptor;
			}
		}

		// Token: 0x06011F64 RID: 73572 RVA: 0x002A0A86 File Offset: 0x0029EC86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSkinChangeRequest()
		{
		}

		// Token: 0x06011F65 RID: 73573 RVA: 0x002A0A8E File Offset: 0x0029EC8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSkinChangeRequest(PhantomSkinChangeRequest other) : this()
		{
			this.incrId_ = other.incrId_;
			this.skinId_ = other.skinId_;
			this.changeDefault_ = other.changeDefault_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011F66 RID: 73574 RVA: 0x002A0ACB File Offset: 0x0029ECCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSkinChangeRequest Clone()
		{
			return new PhantomSkinChangeRequest(this);
		}

		// Token: 0x17003B83 RID: 15235
		// (get) Token: 0x06011F67 RID: 73575 RVA: 0x002A0AD3 File Offset: 0x0029ECD3
		// (set) Token: 0x06011F68 RID: 73576 RVA: 0x002A0ADB File Offset: 0x0029ECDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x17003B84 RID: 15236
		// (get) Token: 0x06011F69 RID: 73577 RVA: 0x002A0AE4 File Offset: 0x0029ECE4
		// (set) Token: 0x06011F6A RID: 73578 RVA: 0x002A0AEC File Offset: 0x0029ECEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x17003B85 RID: 15237
		// (get) Token: 0x06011F6B RID: 73579 RVA: 0x002A0AF5 File Offset: 0x0029ECF5
		// (set) Token: 0x06011F6C RID: 73580 RVA: 0x002A0AFD File Offset: 0x0029ECFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ChangeDefault
		{
			get
			{
				return this.changeDefault_;
			}
			set
			{
				this.changeDefault_ = value;
			}
		}

		// Token: 0x06011F6D RID: 73581 RVA: 0x002A0B06 File Offset: 0x0029ED06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomSkinChangeRequest);
		}

		// Token: 0x06011F6E RID: 73582 RVA: 0x002A0B14 File Offset: 0x0029ED14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomSkinChangeRequest other)
		{
			return other != null && (other == this || (this.IncrId == other.IncrId && this.SkinId == other.SkinId && this.ChangeDefault == other.ChangeDefault && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011F6F RID: 73583 RVA: 0x002A0B70 File Offset: 0x0029ED70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			if (this.ChangeDefault)
			{
				num ^= this.ChangeDefault.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011F70 RID: 73584 RVA: 0x002A0BE1 File Offset: 0x0029EDE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011F71 RID: 73585 RVA: 0x002A0BEE File Offset: 0x0029EDEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011F72 RID: 73586 RVA: 0x002A0BF8 File Offset: 0x0029EDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkinId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SkinId);
			}
			if (this.ChangeDefault)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.ChangeDefault);
			}
			if (this.IncrId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011F73 RID: 73587 RVA: 0x002A0C6C File Offset: 0x0029EE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			if (this.ChangeDefault)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011F74 RID: 73588 RVA: 0x002A0CD0 File Offset: 0x0029EED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomSkinChangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			if (other.ChangeDefault)
			{
				this.ChangeDefault = other.ChangeDefault;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011F75 RID: 73589 RVA: 0x002A0D34 File Offset: 0x0029EF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011F76 RID: 73590 RVA: 0x002A0D40 File Offset: 0x0029EF40
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
					if (num != 48U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IncrId = input.ReadInt32();
						}
					}
					else
					{
						this.ChangeDefault = input.ReadBool();
					}
				}
				else
				{
					this.SkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040070F4 RID: 28916
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070F5 RID: 28917
		public const int IncrIdFieldNumber = 14;

		// Token: 0x040070F6 RID: 28918
		private int incrId_;

		// Token: 0x040070F7 RID: 28919
		public const int SkinIdFieldNumber = 1;

		// Token: 0x040070F8 RID: 28920
		private int skinId_;

		// Token: 0x040070F9 RID: 28921
		public const int ChangeDefaultFieldNumber = 6;

		// Token: 0x040070FA RID: 28922
		private bool changeDefault_;
	}
}
