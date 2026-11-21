using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001280 RID: 4736
	public sealed class SkinRewardActivityRewardInfo : IMessage<SkinRewardActivityRewardInfo>, IMessage, IEquatable<SkinRewardActivityRewardInfo>, IDeepCloneable<SkinRewardActivityRewardInfo>, IBufferMessage
	{
		// Token: 0x0601948D RID: 103565 RVA: 0x003B0341 File Offset: 0x003AE541
		[NullableContext(1)]
		public static SkinRewardActivityRewardInfo Create()
		{
			return new SkinRewardActivityRewardInfo();
		}

		// Token: 0x17005585 RID: 21893
		// (get) Token: 0x0601948E RID: 103566 RVA: 0x003B0348 File Offset: 0x003AE548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SkinRewardActivityRewardInfo> Parser
		{
			get
			{
				return SkinRewardActivityRewardInfo._parser;
			}
		}

		// Token: 0x17005586 RID: 21894
		// (get) Token: 0x0601948F RID: 103567 RVA: 0x003B034F File Offset: 0x003AE54F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005587 RID: 21895
		// (get) Token: 0x06019490 RID: 103568 RVA: 0x003B0352 File Offset: 0x003AE552
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkinRewardActivityRewardInfo.Descriptor;
			}
		}

		// Token: 0x06019491 RID: 103569 RVA: 0x003B0359 File Offset: 0x003AE559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardActivityRewardInfo()
		{
		}

		// Token: 0x06019492 RID: 103570 RVA: 0x003B0361 File Offset: 0x003AE561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardActivityRewardInfo(SkinRewardActivityRewardInfo other) : this()
		{
			this.configId_ = other.configId_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019493 RID: 103571 RVA: 0x003B0392 File Offset: 0x003AE592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardActivityRewardInfo Clone()
		{
			return new SkinRewardActivityRewardInfo(this);
		}

		// Token: 0x17005588 RID: 21896
		// (get) Token: 0x06019494 RID: 103572 RVA: 0x003B039A File Offset: 0x003AE59A
		// (set) Token: 0x06019495 RID: 103573 RVA: 0x003B03A2 File Offset: 0x003AE5A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17005589 RID: 21897
		// (get) Token: 0x06019496 RID: 103574 RVA: 0x003B03AB File Offset: 0x003AE5AB
		// (set) Token: 0x06019497 RID: 103575 RVA: 0x003B03B3 File Offset: 0x003AE5B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardActivityRewardState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x06019498 RID: 103576 RVA: 0x003B03BC File Offset: 0x003AE5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkinRewardActivityRewardInfo);
		}

		// Token: 0x06019499 RID: 103577 RVA: 0x003B03CA File Offset: 0x003AE5CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkinRewardActivityRewardInfo other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601949A RID: 103578 RVA: 0x003B0408 File Offset: 0x003AE608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.State != SkinRewardActivityRewardState.InitState)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601949B RID: 103579 RVA: 0x003B0466 File Offset: 0x003AE666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601949C RID: 103580 RVA: 0x003B0473 File Offset: 0x003AE673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601949D RID: 103581 RVA: 0x003B047C File Offset: 0x003AE67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.State != SkinRewardActivityRewardState.InitState)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601949E RID: 103582 RVA: 0x003B04D4 File Offset: 0x003AE6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.State != SkinRewardActivityRewardState.InitState)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601949F RID: 103583 RVA: 0x003B052C File Offset: 0x003AE72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkinRewardActivityRewardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.State != SkinRewardActivityRewardState.InitState)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060194A0 RID: 103584 RVA: 0x003B057C File Offset: 0x003AE77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060194A1 RID: 103585 RVA: 0x003B0588 File Offset: 0x003AE788
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.State = (SkinRewardActivityRewardState)input.ReadEnum();
					}
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040095A2 RID: 38306
		private static readonly MessageParser<SkinRewardActivityRewardInfo> _parser = new MessageParser<SkinRewardActivityRewardInfo>(() => new SkinRewardActivityRewardInfo());

		// Token: 0x040095A3 RID: 38307
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095A4 RID: 38308
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x040095A5 RID: 38309
		private int configId_;

		// Token: 0x040095A6 RID: 38310
		public const int StateFieldNumber = 2;

		// Token: 0x040095A7 RID: 38311
		private SkinRewardActivityRewardState state_;
	}
}
