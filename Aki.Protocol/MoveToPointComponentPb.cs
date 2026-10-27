using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AC7 RID: 2759
	public sealed class MoveToPointComponentPb : IMessage<MoveToPointComponentPb>, IMessage, IEquatable<MoveToPointComponentPb>, IDeepCloneable<MoveToPointComponentPb>, IBufferMessage
	{
		// Token: 0x0600F03B RID: 61499 RVA: 0x0023191B File Offset: 0x0022FB1B
		[NullableContext(1)]
		public static MoveToPointComponentPb Create()
		{
			return new MoveToPointComponentPb();
		}

		// Token: 0x170030E7 RID: 12519
		// (get) Token: 0x0600F03C RID: 61500 RVA: 0x00231922 File Offset: 0x0022FB22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030E8 RID: 12520
		// (get) Token: 0x0600F03D RID: 61501 RVA: 0x00231925 File Offset: 0x0022FB25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoveToPointComponentPb.Descriptor;
			}
		}

		// Token: 0x0600F03E RID: 61502 RVA: 0x0023192C File Offset: 0x0022FB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveToPointComponentPb()
		{
		}

		// Token: 0x0600F03F RID: 61503 RVA: 0x00231934 File Offset: 0x0022FB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveToPointComponentPb(MoveToPointComponentPb other) : this()
		{
			this.config_ = ((other.config_ != null) ? other.config_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F040 RID: 61504 RVA: 0x00231969 File Offset: 0x0022FB69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveToPointComponentPb Clone()
		{
			return new MoveToPointComponentPb(this);
		}

		// Token: 0x170030E9 RID: 12521
		// (get) Token: 0x0600F041 RID: 61505 RVA: 0x00231971 File Offset: 0x0022FB71
		// (set) Token: 0x0600F042 RID: 61506 RVA: 0x00231979 File Offset: 0x0022FB79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterMoveToPointConfig Config
		{
			get
			{
				return this.config_;
			}
			set
			{
				this.config_ = value;
			}
		}

		// Token: 0x0600F043 RID: 61507 RVA: 0x00231982 File Offset: 0x0022FB82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoveToPointComponentPb);
		}

		// Token: 0x0600F044 RID: 61508 RVA: 0x00231990 File Offset: 0x0022FB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoveToPointComponentPb other)
		{
			return other != null && (other == this || (object.Equals(this.Config, other.Config) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F045 RID: 61509 RVA: 0x002319C4 File Offset: 0x0022FBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.config_ != null)
			{
				num ^= this.Config.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F046 RID: 61510 RVA: 0x00231A00 File Offset: 0x0022FC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F047 RID: 61511 RVA: 0x00231A0D File Offset: 0x0022FC0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F048 RID: 61512 RVA: 0x00231A16 File Offset: 0x0022FC16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.config_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Config);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F049 RID: 61513 RVA: 0x00231A48 File Offset: 0x0022FC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.config_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Config);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F04A RID: 61514 RVA: 0x00231A88 File Offset: 0x0022FC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoveToPointComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.config_ != null)
			{
				if (this.config_ == null)
				{
					this.Config = new CharacterMoveToPointConfig();
				}
				this.Config.MergeFrom(other.Config);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F04B RID: 61515 RVA: 0x00231ADC File Offset: 0x0022FCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F04C RID: 61516 RVA: 0x00231AE8 File Offset: 0x0022FCE8
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.config_ == null)
					{
						this.Config = new CharacterMoveToPointConfig();
					}
					input.ReadMessage(this.Config);
				}
			}
		}

		// Token: 0x04006121 RID: 24865
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006122 RID: 24866
		public const int ConfigFieldNumber = 1;

		// Token: 0x04006123 RID: 24867
		private CharacterMoveToPointConfig config_;
	}
}
