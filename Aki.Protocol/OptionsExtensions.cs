using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001603 RID: 5635
	public static class OptionsExtensions
	{
		// Token: 0x0400BF60 RID: 48992
		public static readonly Extension<MessageOptions, bool> IsMsg = new Extension<MessageOptions, bool>(1001, FieldCodec.ForBool(8008U, false));

		// Token: 0x0400BF61 RID: 48993
		public static readonly Extension<MessageOptions, int> MsgID = new Extension<MessageOptions, int>(1002, FieldCodec.ForInt32(8016U, 0));

		// Token: 0x0400BF62 RID: 48994
		public static readonly Extension<MessageOptions, int> ULDLMask = new Extension<MessageOptions, int>(1003, FieldCodec.ForInt32(8024U, 0));

		// Token: 0x0400BF63 RID: 48995
		public static readonly Extension<MessageOptions, MSG_ROUTE_ENUM> MessageRoute = new Extension<MessageOptions, MSG_ROUTE_ENUM>(1004, FieldCodec.ForEnum<MSG_ROUTE_ENUM>(8032U, (MSG_ROUTE_ENUM x) => (int)x, (int x) => (MSG_ROUTE_ENUM)x, MSG_ROUTE_ENUM.RouteNone));

		// Token: 0x0400BF64 RID: 48996
		public static readonly Extension<MessageOptions, int> Cooldown = new Extension<MessageOptions, int>(1005, FieldCodec.ForInt32(8040U, 0));

		// Token: 0x0400BF65 RID: 48997
		public static readonly Extension<MessageOptions, int> NotCache = new Extension<MessageOptions, int>(1006, FieldCodec.ForInt32(8048U, 0));

		// Token: 0x0400BF66 RID: 48998
		public static readonly Extension<MessageOptions, int> NetworkMask = new Extension<MessageOptions, int>(1007, FieldCodec.ForInt32(8056U, 0));

		// Token: 0x0400BF67 RID: 48999
		public static readonly Extension<MessageOptions, int> MsgLock = new Extension<MessageOptions, int>(1008, FieldCodec.ForInt32(8064U, 0));

		// Token: 0x0400BF68 RID: 49000
		public static readonly Extension<MessageOptions, int> NoEncrypt = new Extension<MessageOptions, int>(1009, FieldCodec.ForInt32(8072U, 0));

		// Token: 0x0400BF69 RID: 49001
		public static readonly Extension<MessageOptions, int> NoReentry = new Extension<MessageOptions, int>(1010, FieldCodec.ForInt32(8080U, 0));

		// Token: 0x0400BF6A RID: 49002
		public static readonly Extension<MessageOptions, int> UdpTransport = new Extension<MessageOptions, int>(1011, FieldCodec.ForInt32(8088U, 0));

		// Token: 0x0400BF6B RID: 49003
		public static readonly Extension<MessageOptions, EMsgFunction> MsgFunction = new Extension<MessageOptions, EMsgFunction>(1012, FieldCodec.ForEnum<EMsgFunction>(8096U, (EMsgFunction x) => (int)x, (int x) => (EMsgFunction)x, EMsgFunction.FunctionNone));

		// Token: 0x0400BF6C RID: 49004
		public static readonly Extension<MessageOptions, int> NeedShuffle = new Extension<MessageOptions, int>(1013, FieldCodec.ForInt32(8104U, 0));

		// Token: 0x0400BF6D RID: 49005
		public static readonly Extension<MessageOptions, int> IsCompress = new Extension<MessageOptions, int>(1014, FieldCodec.ForInt32(8112U, 0));
	}
}
