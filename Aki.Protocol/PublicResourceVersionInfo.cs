using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DE4 RID: 3556
	public sealed class PublicResourceVersionInfo : IMessage<PublicResourceVersionInfo>, IMessage, IEquatable<PublicResourceVersionInfo>, IDeepCloneable<PublicResourceVersionInfo>, IBufferMessage
	{
		// Token: 0x06013286 RID: 78470 RVA: 0x002CAEA9 File Offset: 0x002C90A9
		[NullableContext(1)]
		public static PublicResourceVersionInfo Create()
		{
			return new PublicResourceVersionInfo();
		}

		// Token: 0x17003F97 RID: 16279
		// (get) Token: 0x06013287 RID: 78471 RVA: 0x002CAEB0 File Offset: 0x002C90B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F98 RID: 16280
		// (get) Token: 0x06013288 RID: 78472 RVA: 0x002CAEB3 File Offset: 0x002C90B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PublicResourceVersionInfo.Descriptor;
			}
		}

		// Token: 0x06013289 RID: 78473 RVA: 0x002CAEBA File Offset: 0x002C90BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicResourceVersionInfo()
		{
		}

		// Token: 0x0601328A RID: 78474 RVA: 0x002CAEC2 File Offset: 0x002C90C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicResourceVersionInfo(PublicResourceVersionInfo other) : this()
		{
			this.publicJsonVersion_ = other.publicJsonVersion_;
			this.publicMiscVersion_ = other.publicMiscVersion_;
			this.publicUniverseEditorVersion_ = other.publicUniverseEditorVersion_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601328B RID: 78475 RVA: 0x002CAEFF File Offset: 0x002C90FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicResourceVersionInfo Clone()
		{
			return new PublicResourceVersionInfo(this);
		}

		// Token: 0x17003F99 RID: 16281
		// (get) Token: 0x0601328C RID: 78476 RVA: 0x002CAF07 File Offset: 0x002C9107
		// (set) Token: 0x0601328D RID: 78477 RVA: 0x002CAF0F File Offset: 0x002C910F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PublicJsonVersion
		{
			get
			{
				return this.publicJsonVersion_;
			}
			set
			{
				this.publicJsonVersion_ = value;
			}
		}

		// Token: 0x17003F9A RID: 16282
		// (get) Token: 0x0601328E RID: 78478 RVA: 0x002CAF18 File Offset: 0x002C9118
		// (set) Token: 0x0601328F RID: 78479 RVA: 0x002CAF20 File Offset: 0x002C9120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PublicMiscVersion
		{
			get
			{
				return this.publicMiscVersion_;
			}
			set
			{
				this.publicMiscVersion_ = value;
			}
		}

		// Token: 0x17003F9B RID: 16283
		// (get) Token: 0x06013290 RID: 78480 RVA: 0x002CAF29 File Offset: 0x002C9129
		// (set) Token: 0x06013291 RID: 78481 RVA: 0x002CAF31 File Offset: 0x002C9131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PublicUniverseEditorVersion
		{
			get
			{
				return this.publicUniverseEditorVersion_;
			}
			set
			{
				this.publicUniverseEditorVersion_ = value;
			}
		}

		// Token: 0x06013292 RID: 78482 RVA: 0x002CAF3A File Offset: 0x002C913A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PublicResourceVersionInfo);
		}

		// Token: 0x06013293 RID: 78483 RVA: 0x002CAF48 File Offset: 0x002C9148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PublicResourceVersionInfo other)
		{
			return other != null && (other == this || (this.PublicJsonVersion == other.PublicJsonVersion && this.PublicMiscVersion == other.PublicMiscVersion && this.PublicUniverseEditorVersion == other.PublicUniverseEditorVersion && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013294 RID: 78484 RVA: 0x002CAFA4 File Offset: 0x002C91A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PublicJsonVersion != 0)
			{
				num ^= this.PublicJsonVersion.GetHashCode();
			}
			if (this.PublicMiscVersion != 0)
			{
				num ^= this.PublicMiscVersion.GetHashCode();
			}
			if (this.PublicUniverseEditorVersion != 0)
			{
				num ^= this.PublicUniverseEditorVersion.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013295 RID: 78485 RVA: 0x002CB015 File Offset: 0x002C9215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013296 RID: 78486 RVA: 0x002CB022 File Offset: 0x002C9222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013297 RID: 78487 RVA: 0x002CB02C File Offset: 0x002C922C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PublicJsonVersion != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PublicJsonVersion);
			}
			if (this.PublicMiscVersion != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PublicMiscVersion);
			}
			if (this.PublicUniverseEditorVersion != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PublicUniverseEditorVersion);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013298 RID: 78488 RVA: 0x002CB0A0 File Offset: 0x002C92A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PublicJsonVersion != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PublicJsonVersion);
			}
			if (this.PublicMiscVersion != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PublicMiscVersion);
			}
			if (this.PublicUniverseEditorVersion != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PublicUniverseEditorVersion);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013299 RID: 78489 RVA: 0x002CB110 File Offset: 0x002C9310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PublicResourceVersionInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PublicJsonVersion != 0)
			{
				this.PublicJsonVersion = other.PublicJsonVersion;
			}
			if (other.PublicMiscVersion != 0)
			{
				this.PublicMiscVersion = other.PublicMiscVersion;
			}
			if (other.PublicUniverseEditorVersion != 0)
			{
				this.PublicUniverseEditorVersion = other.PublicUniverseEditorVersion;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601329A RID: 78490 RVA: 0x002CB174 File Offset: 0x002C9374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601329B RID: 78491 RVA: 0x002CB180 File Offset: 0x002C9380
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PublicUniverseEditorVersion = input.ReadInt32();
						}
					}
					else
					{
						this.PublicMiscVersion = input.ReadInt32();
					}
				}
				else
				{
					this.PublicJsonVersion = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007672 RID: 30322
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007673 RID: 30323
		public const int PublicJsonVersionFieldNumber = 1;

		// Token: 0x04007674 RID: 30324
		private int publicJsonVersion_;

		// Token: 0x04007675 RID: 30325
		public const int PublicMiscVersionFieldNumber = 2;

		// Token: 0x04007676 RID: 30326
		private int publicMiscVersion_;

		// Token: 0x04007677 RID: 30327
		public const int PublicUniverseEditorVersionFieldNumber = 3;

		// Token: 0x04007678 RID: 30328
		private int publicUniverseEditorVersion_;
	}
}
