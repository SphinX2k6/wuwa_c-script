using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000781 RID: 1921
	[NetMessage(EMessageId.HonamiStoryPollutionBoxSteadyLimitNotify)]
	public sealed class HonamiStoryPollutionBoxSteadyLimitNotify : IMessage<HonamiStoryPollutionBoxSteadyLimitNotify>, IMessage, IEquatable<HonamiStoryPollutionBoxSteadyLimitNotify>, IDeepCloneable<HonamiStoryPollutionBoxSteadyLimitNotify>, IBufferMessage
	{
		// Token: 0x0600ADCE RID: 44494 RVA: 0x001A1E1F File Offset: 0x001A001F
		[NullableContext(1)]
		public static HonamiStoryPollutionBoxSteadyLimitNotify Create()
		{
			return new HonamiStoryPollutionBoxSteadyLimitNotify();
		}

		// Token: 0x1700230B RID: 8971
		// (get) Token: 0x0600ADCF RID: 44495 RVA: 0x001A1E26 File Offset: 0x001A0026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700230C RID: 8972
		// (get) Token: 0x0600ADD0 RID: 44496 RVA: 0x001A1E29 File Offset: 0x001A0029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryPollutionBoxSteadyLimitNotify.Descriptor;
			}
		}

		// Token: 0x0600ADD1 RID: 44497 RVA: 0x001A1E30 File Offset: 0x001A0030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPollutionBoxSteadyLimitNotify()
		{
		}

		// Token: 0x0600ADD2 RID: 44498 RVA: 0x001A1E38 File Offset: 0x001A0038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPollutionBoxSteadyLimitNotify(HonamiStoryPollutionBoxSteadyLimitNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ADD3 RID: 44499 RVA: 0x001A1E51 File Offset: 0x001A0051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPollutionBoxSteadyLimitNotify Clone()
		{
			return new HonamiStoryPollutionBoxSteadyLimitNotify(this);
		}

		// Token: 0x0600ADD4 RID: 44500 RVA: 0x001A1E59 File Offset: 0x001A0059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryPollutionBoxSteadyLimitNotify);
		}

		// Token: 0x0600ADD5 RID: 44501 RVA: 0x001A1E67 File Offset: 0x001A0067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryPollutionBoxSteadyLimitNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600ADD6 RID: 44502 RVA: 0x001A1E88 File Offset: 0x001A0088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ADD7 RID: 44503 RVA: 0x001A1EAE File Offset: 0x001A00AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ADD8 RID: 44504 RVA: 0x001A1EBB File Offset: 0x001A00BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ADD9 RID: 44505 RVA: 0x001A1EC4 File Offset: 0x001A00C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ADDA RID: 44506 RVA: 0x001A1EDC File Offset: 0x001A00DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ADDB RID: 44507 RVA: 0x001A1F02 File Offset: 0x001A0102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryPollutionBoxSteadyLimitNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ADDC RID: 44508 RVA: 0x001A1F1F File Offset: 0x001A011F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ADDD RID: 44509 RVA: 0x001A1F28 File Offset: 0x001A0128
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004EE0 RID: 20192
		private UnknownFieldSet _unknownFields;
	}
}
