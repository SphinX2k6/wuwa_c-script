using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000795 RID: 1941
	[NetMessage(EMessageId.HonamiStoryPollutionBoxSteadyLimitNotify)]
	public sealed class HonamiStoryPollutionBoxSteadyLimitNotify : IMessage<HonamiStoryPollutionBoxSteadyLimitNotify>, IMessage, IEquatable<HonamiStoryPollutionBoxSteadyLimitNotify>, IDeepCloneable<HonamiStoryPollutionBoxSteadyLimitNotify>, IBufferMessage
	{
		// Token: 0x0600AF24 RID: 44836 RVA: 0x001A4847 File Offset: 0x001A2A47
		[NullableContext(1)]
		public static HonamiStoryPollutionBoxSteadyLimitNotify Create()
		{
			return new HonamiStoryPollutionBoxSteadyLimitNotify();
		}

		// Token: 0x17002355 RID: 9045
		// (get) Token: 0x0600AF25 RID: 44837 RVA: 0x001A484E File Offset: 0x001A2A4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002356 RID: 9046
		// (get) Token: 0x0600AF26 RID: 44838 RVA: 0x001A4851 File Offset: 0x001A2A51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryPollutionBoxSteadyLimitNotify.Descriptor;
			}
		}

		// Token: 0x0600AF27 RID: 44839 RVA: 0x001A4858 File Offset: 0x001A2A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPollutionBoxSteadyLimitNotify()
		{
		}

		// Token: 0x0600AF28 RID: 44840 RVA: 0x001A4860 File Offset: 0x001A2A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPollutionBoxSteadyLimitNotify(HonamiStoryPollutionBoxSteadyLimitNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF29 RID: 44841 RVA: 0x001A4879 File Offset: 0x001A2A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPollutionBoxSteadyLimitNotify Clone()
		{
			return new HonamiStoryPollutionBoxSteadyLimitNotify(this);
		}

		// Token: 0x0600AF2A RID: 44842 RVA: 0x001A4881 File Offset: 0x001A2A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryPollutionBoxSteadyLimitNotify);
		}

		// Token: 0x0600AF2B RID: 44843 RVA: 0x001A488F File Offset: 0x001A2A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryPollutionBoxSteadyLimitNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600AF2C RID: 44844 RVA: 0x001A48B0 File Offset: 0x001A2AB0
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

		// Token: 0x0600AF2D RID: 44845 RVA: 0x001A48D6 File Offset: 0x001A2AD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AF2E RID: 44846 RVA: 0x001A48E3 File Offset: 0x001A2AE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF2F RID: 44847 RVA: 0x001A48EC File Offset: 0x001A2AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF30 RID: 44848 RVA: 0x001A4904 File Offset: 0x001A2B04
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

		// Token: 0x0600AF31 RID: 44849 RVA: 0x001A492A File Offset: 0x001A2B2A
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

		// Token: 0x0600AF32 RID: 44850 RVA: 0x001A4947 File Offset: 0x001A2B47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF33 RID: 44851 RVA: 0x001A4950 File Offset: 0x001A2B50
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

		// Token: 0x04004EE7 RID: 20199
		private UnknownFieldSet _unknownFields;
	}
}
