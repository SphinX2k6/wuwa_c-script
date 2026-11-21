using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AB6 RID: 2742
	public sealed class MoveToPointComponentPb : IMessage<MoveToPointComponentPb>, IMessage, IEquatable<MoveToPointComponentPb>, IDeepCloneable<MoveToPointComponentPb>, IBufferMessage
	{
		// Token: 0x0600EF21 RID: 61217 RVA: 0x0022F70E File Offset: 0x0022D90E
		[NullableContext(1)]
		public static MoveToPointComponentPb Create()
		{
			return new MoveToPointComponentPb();
		}

		// Token: 0x170030A9 RID: 12457
		// (get) Token: 0x0600EF22 RID: 61218 RVA: 0x0022F715 File Offset: 0x0022D915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030AA RID: 12458
		// (get) Token: 0x0600EF23 RID: 61219 RVA: 0x0022F718 File Offset: 0x0022D918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoveToPointComponentPb.Descriptor;
			}
		}

		// Token: 0x0600EF24 RID: 61220 RVA: 0x0022F71F File Offset: 0x0022D91F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveToPointComponentPb()
		{
		}

		// Token: 0x0600EF25 RID: 61221 RVA: 0x0022F727 File Offset: 0x0022D927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveToPointComponentPb(MoveToPointComponentPb other) : this()
		{
			this.config_ = ((other.config_ != null) ? other.config_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EF26 RID: 61222 RVA: 0x0022F75C File Offset: 0x0022D95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveToPointComponentPb Clone()
		{
			return new MoveToPointComponentPb(this);
		}

		// Token: 0x170030AB RID: 12459
		// (get) Token: 0x0600EF27 RID: 61223 RVA: 0x0022F764 File Offset: 0x0022D964
		// (set) Token: 0x0600EF28 RID: 61224 RVA: 0x0022F76C File Offset: 0x0022D96C
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

		// Token: 0x0600EF29 RID: 61225 RVA: 0x0022F775 File Offset: 0x0022D975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoveToPointComponentPb);
		}

		// Token: 0x0600EF2A RID: 61226 RVA: 0x0022F783 File Offset: 0x0022D983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoveToPointComponentPb other)
		{
			return other != null && (other == this || (object.Equals(this.Config, other.Config) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EF2B RID: 61227 RVA: 0x0022F7B8 File Offset: 0x0022D9B8
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

		// Token: 0x0600EF2C RID: 61228 RVA: 0x0022F7F4 File Offset: 0x0022D9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EF2D RID: 61229 RVA: 0x0022F801 File Offset: 0x0022DA01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EF2E RID: 61230 RVA: 0x0022F80A File Offset: 0x0022DA0A
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

		// Token: 0x0600EF2F RID: 61231 RVA: 0x0022F83C File Offset: 0x0022DA3C
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

		// Token: 0x0600EF30 RID: 61232 RVA: 0x0022F87C File Offset: 0x0022DA7C
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

		// Token: 0x0600EF31 RID: 61233 RVA: 0x0022F8D0 File Offset: 0x0022DAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EF32 RID: 61234 RVA: 0x0022F8DC File Offset: 0x0022DADC
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

		// Token: 0x0400612A RID: 24874
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400612B RID: 24875
		public const int ConfigFieldNumber = 1;

		// Token: 0x0400612C RID: 24876
		private CharacterMoveToPointConfig config_;
	}
}
