using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200151C RID: 5404
	[NetMessage(EMessageId.UpdateSceneDateRequest)]
	public sealed class UpdateSceneDateRequest : IMessage<UpdateSceneDateRequest>, IMessage, IEquatable<UpdateSceneDateRequest>, IDeepCloneable<UpdateSceneDateRequest>, IBufferMessage
	{
		// Token: 0x0601CA10 RID: 117264 RVA: 0x0042602F File Offset: 0x0042422F
		[NullableContext(1)]
		public static UpdateSceneDateRequest Create()
		{
			return new UpdateSceneDateRequest();
		}

		// Token: 0x170060D5 RID: 24789
		// (get) Token: 0x0601CA11 RID: 117265 RVA: 0x00426036 File Offset: 0x00424236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060D6 RID: 24790
		// (get) Token: 0x0601CA12 RID: 117266 RVA: 0x00426039 File Offset: 0x00424239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateSceneDateRequest.Descriptor;
			}
		}

		// Token: 0x0601CA13 RID: 117267 RVA: 0x00426040 File Offset: 0x00424240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneDateRequest()
		{
		}

		// Token: 0x0601CA14 RID: 117268 RVA: 0x00426048 File Offset: 0x00424248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneDateRequest(UpdateSceneDateRequest other) : this()
		{
			this.addDays_ = other.addDays_;
			this.hour_ = other.hour_;
			this.minute_ = other.minute_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CA15 RID: 117269 RVA: 0x0042609C File Offset: 0x0042429C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneDateRequest Clone()
		{
			return new UpdateSceneDateRequest(this);
		}

		// Token: 0x170060D7 RID: 24791
		// (get) Token: 0x0601CA16 RID: 117270 RVA: 0x004260A4 File Offset: 0x004242A4
		// (set) Token: 0x0601CA17 RID: 117271 RVA: 0x004260AC File Offset: 0x004242AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AddDays
		{
			get
			{
				return this.addDays_;
			}
			set
			{
				this.addDays_ = value;
			}
		}

		// Token: 0x170060D8 RID: 24792
		// (get) Token: 0x0601CA18 RID: 117272 RVA: 0x004260B5 File Offset: 0x004242B5
		// (set) Token: 0x0601CA19 RID: 117273 RVA: 0x004260BD File Offset: 0x004242BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Hour
		{
			get
			{
				return this.hour_;
			}
			set
			{
				this.hour_ = value;
			}
		}

		// Token: 0x170060D9 RID: 24793
		// (get) Token: 0x0601CA1A RID: 117274 RVA: 0x004260C6 File Offset: 0x004242C6
		// (set) Token: 0x0601CA1B RID: 117275 RVA: 0x004260CE File Offset: 0x004242CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Minute
		{
			get
			{
				return this.minute_;
			}
			set
			{
				this.minute_ = value;
			}
		}

		// Token: 0x170060DA RID: 24794
		// (get) Token: 0x0601CA1C RID: 117276 RVA: 0x004260D7 File Offset: 0x004242D7
		// (set) Token: 0x0601CA1D RID: 117277 RVA: 0x004260DF File Offset: 0x004242DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneDateUpdateReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x0601CA1E RID: 117278 RVA: 0x004260E8 File Offset: 0x004242E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateSceneDateRequest);
		}

		// Token: 0x0601CA1F RID: 117279 RVA: 0x004260F8 File Offset: 0x004242F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateSceneDateRequest other)
		{
			return other != null && (other == this || (this.AddDays == other.AddDays && this.Hour == other.Hour && this.Minute == other.Minute && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CA20 RID: 117280 RVA: 0x00426164 File Offset: 0x00424364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AddDays != 0U)
			{
				num ^= this.AddDays.GetHashCode();
			}
			if (this.Hour != 0)
			{
				num ^= this.Hour.GetHashCode();
			}
			if (this.Minute != 0)
			{
				num ^= this.Minute.GetHashCode();
			}
			if (this.Reason != SceneDateUpdateReason.TimeFlowAuto)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CA21 RID: 117281 RVA: 0x004261F4 File Offset: 0x004243F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CA22 RID: 117282 RVA: 0x00426201 File Offset: 0x00424401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CA23 RID: 117283 RVA: 0x0042620C File Offset: 0x0042440C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Hour != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Hour);
			}
			if (this.AddDays != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.AddDays);
			}
			if (this.Minute != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Minute);
			}
			if (this.Reason != SceneDateUpdateReason.TimeFlowAuto)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CA24 RID: 117284 RVA: 0x004262A0 File Offset: 0x004244A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AddDays != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AddDays);
			}
			if (this.Hour != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Hour);
			}
			if (this.Minute != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Minute);
			}
			if (this.Reason != SceneDateUpdateReason.TimeFlowAuto)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CA25 RID: 117285 RVA: 0x00426328 File Offset: 0x00424528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateSceneDateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AddDays != 0U)
			{
				this.AddDays = other.AddDays;
			}
			if (other.Hour != 0)
			{
				this.Hour = other.Hour;
			}
			if (other.Minute != 0)
			{
				this.Minute = other.Minute;
			}
			if (other.Reason != SceneDateUpdateReason.TimeFlowAuto)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CA26 RID: 117286 RVA: 0x004263A0 File Offset: 0x004245A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CA27 RID: 117287 RVA: 0x004263AC File Offset: 0x004245AC
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
				if (num <= 32U)
				{
					if (num == 24U)
					{
						this.Hour = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.AddDays = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.Minute = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Reason = (SceneDateUpdateReason)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A4F1 RID: 42225
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A4F2 RID: 42226
		public const int AddDaysFieldNumber = 4;

		// Token: 0x0400A4F3 RID: 42227
		private uint addDays_;

		// Token: 0x0400A4F4 RID: 42228
		public const int HourFieldNumber = 3;

		// Token: 0x0400A4F5 RID: 42229
		private int hour_;

		// Token: 0x0400A4F6 RID: 42230
		public const int MinuteFieldNumber = 9;

		// Token: 0x0400A4F7 RID: 42231
		private int minute_;

		// Token: 0x0400A4F8 RID: 42232
		public const int ReasonFieldNumber = 15;

		// Token: 0x0400A4F9 RID: 42233
		private SceneDateUpdateReason reason_;
	}
}
