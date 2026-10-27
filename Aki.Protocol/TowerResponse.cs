using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013C8 RID: 5064
	[NetMessage(EMessageId.TowerResponse)]
	public sealed class TowerResponse : IMessage<TowerResponse>, IMessage, IEquatable<TowerResponse>, IDeepCloneable<TowerResponse>, IBufferMessage
	{
		// Token: 0x0601ADC3 RID: 110019 RVA: 0x003E4D7B File Offset: 0x003E2F7B
		[NullableContext(1)]
		public static TowerResponse Create()
		{
			return new TowerResponse();
		}

		// Token: 0x17005A96 RID: 23190
		// (get) Token: 0x0601ADC4 RID: 110020 RVA: 0x003E4D82 File Offset: 0x003E2F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A97 RID: 23191
		// (get) Token: 0x0601ADC5 RID: 110021 RVA: 0x003E4D85 File Offset: 0x003E2F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerResponse.Descriptor;
			}
		}

		// Token: 0x0601ADC6 RID: 110022 RVA: 0x003E4D8C File Offset: 0x003E2F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerResponse()
		{
		}

		// Token: 0x0601ADC7 RID: 110023 RVA: 0x003E4D94 File Offset: 0x003E2F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerResponse(TowerResponse other) : this()
		{
			this.towerInfo_ = ((other.towerInfo_ != null) ? other.towerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ADC8 RID: 110024 RVA: 0x003E4DC9 File Offset: 0x003E2FC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerResponse Clone()
		{
			return new TowerResponse(this);
		}

		// Token: 0x17005A98 RID: 23192
		// (get) Token: 0x0601ADC9 RID: 110025 RVA: 0x003E4DD1 File Offset: 0x003E2FD1
		// (set) Token: 0x0601ADCA RID: 110026 RVA: 0x003E4DD9 File Offset: 0x003E2FD9
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

		// Token: 0x0601ADCB RID: 110027 RVA: 0x003E4DE2 File Offset: 0x003E2FE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerResponse);
		}

		// Token: 0x0601ADCC RID: 110028 RVA: 0x003E4DF0 File Offset: 0x003E2FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerResponse other)
		{
			return other != null && (other == this || (object.Equals(this.TowerInfo, other.TowerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ADCD RID: 110029 RVA: 0x003E4E24 File Offset: 0x003E3024
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

		// Token: 0x0601ADCE RID: 110030 RVA: 0x003E4E60 File Offset: 0x003E3060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ADCF RID: 110031 RVA: 0x003E4E6D File Offset: 0x003E306D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ADD0 RID: 110032 RVA: 0x003E4E76 File Offset: 0x003E3076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.towerInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.TowerInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ADD1 RID: 110033 RVA: 0x003E4EA8 File Offset: 0x003E30A8
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

		// Token: 0x0601ADD2 RID: 110034 RVA: 0x003E4EE8 File Offset: 0x003E30E8
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

		// Token: 0x0601ADD3 RID: 110035 RVA: 0x003E4F3C File Offset: 0x003E313C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ADD4 RID: 110036 RVA: 0x003E4F48 File Offset: 0x003E3148
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
					if (this.towerInfo_ == null)
					{
						this.TowerInfo = new TowerInfo();
					}
					input.ReadMessage(this.TowerInfo);
				}
			}
		}

		// Token: 0x04009BD7 RID: 39895
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BD8 RID: 39896
		public const int TowerInfoFieldNumber = 10;

		// Token: 0x04009BD9 RID: 39897
		private TowerInfo towerInfo_;
	}
}
