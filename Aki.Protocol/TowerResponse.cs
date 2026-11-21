using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200143B RID: 5179
	[NetMessage(EMessageId.TowerResponse)]
	public sealed class TowerResponse : IMessage<TowerResponse>, IMessage, IEquatable<TowerResponse>, IDeepCloneable<TowerResponse>, IBufferMessage
	{
		// Token: 0x0601B84E RID: 112718 RVA: 0x0040003F File Offset: 0x003FE23F
		[NullableContext(1)]
		public static TowerResponse Create()
		{
			return new TowerResponse();
		}

		// Token: 0x17005D2B RID: 23851
		// (get) Token: 0x0601B84F RID: 112719 RVA: 0x00400046 File Offset: 0x003FE246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D2C RID: 23852
		// (get) Token: 0x0601B850 RID: 112720 RVA: 0x00400049 File Offset: 0x003FE249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerResponse.Descriptor;
			}
		}

		// Token: 0x0601B851 RID: 112721 RVA: 0x00400050 File Offset: 0x003FE250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerResponse()
		{
		}

		// Token: 0x0601B852 RID: 112722 RVA: 0x00400058 File Offset: 0x003FE258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerResponse(TowerResponse other) : this()
		{
			this.towerInfo_ = ((other.towerInfo_ != null) ? other.towerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B853 RID: 112723 RVA: 0x0040008D File Offset: 0x003FE28D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerResponse Clone()
		{
			return new TowerResponse(this);
		}

		// Token: 0x17005D2D RID: 23853
		// (get) Token: 0x0601B854 RID: 112724 RVA: 0x00400095 File Offset: 0x003FE295
		// (set) Token: 0x0601B855 RID: 112725 RVA: 0x0040009D File Offset: 0x003FE29D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerInfo TowerInfo
		{
			get
			{
				return this.towerInfo_;
			}
			set
			{
				this.towerInfo_ = value;
			}
		}

		// Token: 0x0601B856 RID: 112726 RVA: 0x004000A6 File Offset: 0x003FE2A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerResponse);
		}

		// Token: 0x0601B857 RID: 112727 RVA: 0x004000B4 File Offset: 0x003FE2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerResponse other)
		{
			return other != null && (other == this || (object.Equals(this.TowerInfo, other.TowerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B858 RID: 112728 RVA: 0x004000E8 File Offset: 0x003FE2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.towerInfo_ != null)
			{
				num ^= this.TowerInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B859 RID: 112729 RVA: 0x00400124 File Offset: 0x003FE324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B85A RID: 112730 RVA: 0x00400131 File Offset: 0x003FE331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B85B RID: 112731 RVA: 0x0040013A File Offset: 0x003FE33A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.towerInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TowerInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B85C RID: 112732 RVA: 0x0040016C File Offset: 0x003FE36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.towerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TowerInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B85D RID: 112733 RVA: 0x004001AC File Offset: 0x003FE3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.towerInfo_ != null)
			{
				if (this.towerInfo_ == null)
				{
					this.TowerInfo = new TowerInfo();
				}
				this.TowerInfo.MergeFrom(other.TowerInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B85E RID: 112734 RVA: 0x00400200 File Offset: 0x003FE400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B85F RID: 112735 RVA: 0x0040020C File Offset: 0x003FE40C
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.towerInfo_ == null)
					{
						this.TowerInfo = new TowerInfo();
					}
					input.ReadMessage(this.TowerInfo);
				}
			}
		}

		// Token: 0x0400A01E RID: 40990
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A01F RID: 40991
		public const int TowerInfoFieldNumber = 2;

		// Token: 0x0400A020 RID: 40992
		private TowerInfo towerInfo_;
	}
}
