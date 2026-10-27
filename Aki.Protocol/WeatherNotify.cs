using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001501 RID: 5377
	[NetMessage(EMessageId.WeatherNotify)]
	public sealed class WeatherNotify : IMessage<WeatherNotify>, IMessage, IEquatable<WeatherNotify>, IDeepCloneable<WeatherNotify>, IBufferMessage
	{
		// Token: 0x0601C6BE RID: 116414 RVA: 0x0041AF35 File Offset: 0x00419135
		[NullableContext(1)]
		public static WeatherNotify Create()
		{
			return new WeatherNotify();
		}

		// Token: 0x17005FCE RID: 24526
		// (get) Token: 0x0601C6BF RID: 116415 RVA: 0x0041AF3C File Offset: 0x0041913C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FCF RID: 24527
		// (get) Token: 0x0601C6C0 RID: 116416 RVA: 0x0041AF3F File Offset: 0x0041913F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeatherNotify.Descriptor;
			}
		}

		// Token: 0x0601C6C1 RID: 116417 RVA: 0x0041AF46 File Offset: 0x00419146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherNotify()
		{
		}

		// Token: 0x0601C6C2 RID: 116418 RVA: 0x0041AF4E File Offset: 0x0041914E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherNotify(WeatherNotify other) : this()
		{
			this.weatherId_ = other.weatherId_;
			this.isClient_ = other.isClient_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C6C3 RID: 116419 RVA: 0x0041AF7F File Offset: 0x0041917F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherNotify Clone()
		{
			return new WeatherNotify(this);
		}

		// Token: 0x17005FD0 RID: 24528
		// (get) Token: 0x0601C6C4 RID: 116420 RVA: 0x0041AF87 File Offset: 0x00419187
		// (set) Token: 0x0601C6C5 RID: 116421 RVA: 0x0041AF8F File Offset: 0x0041918F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeatherId
		{
			get
			{
				return this.weatherId_;
			}
			set
			{
				this.weatherId_ = value;
			}
		}

		// Token: 0x17005FD1 RID: 24529
		// (get) Token: 0x0601C6C6 RID: 116422 RVA: 0x0041AF98 File Offset: 0x00419198
		// (set) Token: 0x0601C6C7 RID: 116423 RVA: 0x0041AFA0 File Offset: 0x004191A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsClient
		{
			get
			{
				return this.isClient_;
			}
			set
			{
				this.isClient_ = value;
			}
		}

		// Token: 0x0601C6C8 RID: 116424 RVA: 0x0041AFA9 File Offset: 0x004191A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeatherNotify);
		}

		// Token: 0x0601C6C9 RID: 116425 RVA: 0x0041AFB7 File Offset: 0x004191B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeatherNotify other)
		{
			return other != null && (other == this || (this.WeatherId == other.WeatherId && this.IsClient == other.IsClient && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C6CA RID: 116426 RVA: 0x0041AFF8 File Offset: 0x004191F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeatherId != 0)
			{
				num ^= this.WeatherId.GetHashCode();
			}
			if (this.IsClient)
			{
				num ^= this.IsClient.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C6CB RID: 116427 RVA: 0x0041B050 File Offset: 0x00419250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C6CC RID: 116428 RVA: 0x0041B05D File Offset: 0x0041925D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C6CD RID: 116429 RVA: 0x0041B068 File Offset: 0x00419268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeatherId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.WeatherId);
			}
			if (this.IsClient)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsClient);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C6CE RID: 116430 RVA: 0x0041B0C4 File Offset: 0x004192C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeatherId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeatherId);
			}
			if (this.IsClient)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C6CF RID: 116431 RVA: 0x0041B110 File Offset: 0x00419310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeatherNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeatherId != 0)
			{
				this.WeatherId = other.WeatherId;
			}
			if (other.IsClient)
			{
				this.IsClient = other.IsClient;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C6D0 RID: 116432 RVA: 0x0041B160 File Offset: 0x00419360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C6D1 RID: 116433 RVA: 0x0041B16C File Offset: 0x0041936C
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
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsClient = input.ReadBool();
					}
				}
				else
				{
					this.WeatherId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A2B8 RID: 41656
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2B9 RID: 41657
		public const int WeatherIdFieldNumber = 6;

		// Token: 0x0400A2BA RID: 41658
		private int weatherId_;

		// Token: 0x0400A2BB RID: 41659
		public const int IsClientFieldNumber = 7;

		// Token: 0x0400A2BC RID: 41660
		private bool isClient_;
	}
}
