using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001A8 RID: 424
	[NetMessage(EMessageId.BlackCoastThemeActiveRewardRequest)]
	public sealed class BlackCoastThemeActiveRewardRequest : IMessage<BlackCoastThemeActiveRewardRequest>, IMessage, IEquatable<BlackCoastThemeActiveRewardRequest>, IDeepCloneable<BlackCoastThemeActiveRewardRequest>, IBufferMessage
	{
		// Token: 0x060031FA RID: 12794 RVA: 0x0007F7C5 File Offset: 0x0007D9C5
		[NullableContext(1)]
		public static BlackCoastThemeActiveRewardRequest Create()
		{
			return new BlackCoastThemeActiveRewardRequest();
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x060031FB RID: 12795 RVA: 0x0007F7CC File Offset: 0x0007D9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x060031FC RID: 12796 RVA: 0x0007F7CF File Offset: 0x0007D9CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackCoastThemeActiveRewardRequest.Descriptor;
			}
		}

		// Token: 0x060031FD RID: 12797 RVA: 0x0007F7D6 File Offset: 0x0007D9D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeActiveRewardRequest()
		{
		}

		// Token: 0x060031FE RID: 12798 RVA: 0x0007F7E9 File Offset: 0x0007D9E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeActiveRewardRequest(BlackCoastThemeActiveRewardRequest other) : this()
		{
			this.activeRewardIds_ = other.activeRewardIds_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x0007F81F File Offset: 0x0007DA1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeActiveRewardRequest Clone()
		{
			return new BlackCoastThemeActiveRewardRequest(this);
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06003200 RID: 12800 RVA: 0x0007F827 File Offset: 0x0007DA27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ActiveRewardIds
		{
			get
			{
				return this.activeRewardIds_;
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06003201 RID: 12801 RVA: 0x0007F82F File Offset: 0x0007DA2F
		// (set) Token: 0x06003202 RID: 12802 RVA: 0x0007F837 File Offset: 0x0007DA37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x0007F840 File Offset: 0x0007DA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackCoastThemeActiveRewardRequest);
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x0007F850 File Offset: 0x0007DA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackCoastThemeActiveRewardRequest other)
		{
			return other != null && (other == this || (this.activeRewardIds_.Equals(other.activeRewardIds_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x0007F8A0 File Offset: 0x0007DAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.activeRewardIds_.GetHashCode();
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003206 RID: 12806 RVA: 0x0007F8ED File Offset: 0x0007DAED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003207 RID: 12807 RVA: 0x0007F8FA File Offset: 0x0007DAFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x0007F904 File Offset: 0x0007DB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activeRewardIds_.WriteTo(ref output, BlackCoastThemeActiveRewardRequest._repeated_activeRewardIds_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003209 RID: 12809 RVA: 0x0007F954 File Offset: 0x0007DB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activeRewardIds_.CalculateSize(BlackCoastThemeActiveRewardRequest._repeated_activeRewardIds_codec);
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600320A RID: 12810 RVA: 0x0007F9A8 File Offset: 0x0007DBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlackCoastThemeActiveRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.activeRewardIds_.Add(other.activeRewardIds_);
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600320B RID: 12811 RVA: 0x0007F9F5 File Offset: 0x0007DBF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600320C RID: 12812 RVA: 0x0007FA00 File Offset: 0x0007DC00
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
				if (num != 40U && num != 42U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.activeRewardIds_.AddEntriesFrom(ref input, BlackCoastThemeActiveRewardRequest._repeated_activeRewardIds_codec);
				}
			}
		}

		// Token: 0x040029AC RID: 10668
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029AD RID: 10669
		public const int ActiveRewardIdsFieldNumber = 5;

		// Token: 0x040029AE RID: 10670
		private static readonly FieldCodec<int> _repeated_activeRewardIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x040029AF RID: 10671
		private readonly RepeatedField<int> activeRewardIds_ = new RepeatedField<int>();

		// Token: 0x040029B0 RID: 10672
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x040029B1 RID: 10673
		private int activityId_;
	}
}
